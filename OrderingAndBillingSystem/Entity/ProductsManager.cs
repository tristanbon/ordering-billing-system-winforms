
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class ProductsManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Product> products = new List<Product>();

        public void AddProducts(Product prod)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO products (`pName`, `pPrice`,`categoryId`,`pImage`,`status`) VALUES (@pName,@pPrice,@categoryId,@pImage,@status)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pName", prod.ItemName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pPrice", prod.Price));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("categoryId", prod.CategoryId));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pImage", prod.ItemImage));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("status", prod.Status));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }


        public void UpdateProducts(Product prod)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Update products Set pName = @Name, pPrice = @price, categoryId = @cat, pImage = @img, status= @status where pId = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@Name", prod.ItemName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@price", prod.Price));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@cat", prod.CategoryId));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@img", prod.ItemImage));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@status", prod.Status));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", prod.Id));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void DeleteProducts(Product prod)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `products` WHERE `products`.`pId` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", prod.Id));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            connection.Close();
        }

        

        public List<Product> GetProductsAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM `products` ORDER BY `products`.`pName`";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                products.Clear();
                while (Reader.Read())
                {
                    Product prod = new Product();
                    prod.Id = Convert.ToInt32(Reader[0].ToString());
                    prod.ItemName = Reader[1].ToString();
                    prod.Price = Convert.ToDouble(Reader[2].ToString());
                    prod.CategoryId = Convert.ToInt32(Reader[3].ToString());

                    if (Reader[4].ToString() != "")
                    {
                        prod.ItemImage = (byte[])Reader[4];
                    }
                    prod.Status = Convert.ToInt32(Reader[5].ToString());

                    products.Add(prod);
                }

                connection.Close();
                return products;
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
