using MySql.Data.MySqlClient;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class OrderItemsManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<OrderItems> orderitems = new List<OrderItems>();

        public void AddOrderItem(OrderItems odrItm)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "INSERT INTO tblorderitems (`detailId`, `mainId`, `proId`, `qty`, `price`, `amount`)VALUES (@detailId,@mainId,@proId,@qty,@price,@amount)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("detailId", odrItm.ID));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("mainId", odrItm.OrderId));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("proId", odrItm.ProID));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("qty", odrItm.Quantity));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("price", odrItm.Price));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("amount", odrItm.Amount));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

        public void UpdateOrderItem(OrderItems odrItm)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "Update tblorderitems set proId = @proId, qty = @qty, price = @price, amount=@amount where detailId = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@proId", odrItm.ProID));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@qty", odrItm.Quantity));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@price", odrItm.Price));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@amount", odrItm.Amount));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", odrItm.ID));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

        public void DeleteOrederItem(int id)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `tblorderitems` WHERE `tblorderitems`.`detailId` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", id));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            connection.Close();
        }

        public List<OrderItems> GetOrderItemsAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT a.`detailId`, a.`mainId`, a.`proId`, b.`pName`, a.`qty`, a.`price`, a.`amount`, c.`catName` FROM `tblorderitems` AS a " +
                                "INNER JOIN `products` AS b ON a.`proId` = b.`pId` INNER JOIN `category` AS c ON b.`categoryId` = c.`catId` ORDER BY b.`pName` ASC;";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                orderitems.Clear();
                while (Reader.Read())
                {
                    OrderItems itm = new OrderItems();
                    itm.ID = Convert.ToInt32(Reader[0].ToString());
                    itm.OrderId = Convert.ToInt32(Reader[1].ToString());
                    itm.ProID    = Convert.ToInt32(Reader[2].ToString());
                    itm.ItemName = Reader[3].ToString();
                    itm.Quantity = Convert.ToInt32(Reader[4].ToString());
                    itm.Price = Convert.ToDouble(Reader[5].ToString());
                    itm.Amount = Convert.ToDouble(Reader[6].ToString());
                    itm.CategoryName = Reader[7].ToString();

                    orderitems.Add(itm);
                }

                connection.Close();
                return orderitems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }


        public List<OrderItems> GetOrderItemsByOrderId(int orderId)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT a.`detailId`, a.`mainId`, a.`proId`, b.`pName`, a.`qty`, a.`price`, a.`amount`, c.`catName` FROM `tblorderitems` AS a " +
                                "INNER JOIN `products` AS b ON a.`proId` = b.`pId` INNER JOIN `category` AS c ON b.`categoryId` = c.`catId` " +
                                $"WHERE a.`mainId` = {orderId} ORDER BY b.`pName` ASC;";

                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                orderitems.Clear();
                while (Reader.Read())
                {
                    OrderItems itm = new OrderItems();
                    itm.ID = Convert.ToInt32(Reader[0].ToString());
                    itm.OrderId = Convert.ToInt32(Reader[1].ToString());
                    itm.ProID = Convert.ToInt32(Reader[2].ToString());
                    itm.ItemName = Reader[3].ToString();
                    itm.Quantity = Convert.ToInt32(Reader[4].ToString());
                    itm.Price = Convert.ToDouble(Reader[5].ToString());
                    itm.Amount = Convert.ToDouble(Reader[6].ToString());
                    itm.CategoryName = Reader[7].ToString();

                    orderitems.Add(itm);
                }

                connection.Close();
                return orderitems;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }

    }


}

