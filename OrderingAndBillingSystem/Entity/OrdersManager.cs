using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Entity
{
    class OrdersManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;


        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }


        List<Orders> orders = new List<Orders>();
        public void AddOrder(Orders order)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();

            string commandString;
            try
            {
                commandString = @"INSERT INTO tblorders (oDate, oTime, tableName, waiterName, orderType, total, received, ochange, orderno, custid,paymentStatus,discount)
                     VALUES (@oDate, @oTime, @tableName, @waiterName, @orderType, @total, @received, @ochange, @orderno, @custid,@paymentStatus,@discount);
                     SELECT LAST_INSERT_ID()"; // Use LAST_INSERT_ID() to get the recently inserted ID
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("oDate", order.OrderDate));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("oTime", order.OrderTime));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("tablename", order.TableName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("waitername", order.WaiterName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("orderType", order.OrderType));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("total", order.Total));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("received", order.Received));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ochange", order.OrderChanged));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("orderno", order.OrderNo));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("custid", order.CustomerId));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("paymentStatus", order.PaymentStatus));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("discount", order.Discount));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();

        }
        public void UpdateOrder(Orders order)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = @"Update tblorders set oDate = @oDate, oTime = @oTime,  total =@total, received = @received, 
                                  ochange = @ochange, paymentStatus = @paymentStatus, discount = @discount where mainId = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@oDate", order.OrderDate));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@oTime", order.OrderTime));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@total", order.Total));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@received", order.Received));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ochange", order.OrderChanged));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@paymentStatus", order.PaymentStatus));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@discount", order.Discount));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", order.Id));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public List<Orders> GetOrdersAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM tblorders";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                orders.Clear();

                while (Reader.Read())
                {
                    Orders order = new Orders();
                    order.Id = Convert.ToInt32(Reader[0].ToString());
                    order.OrderDate = Convert.ToDateTime(Reader[1].ToString());
                    order.OrderTime = Reader[2].ToString();
                    order.TableName = Reader[3].ToString();
                    order.WaiterName = Reader[4].ToString();
                    order.OrderType = Reader[5].ToString();
                    order.Total = Convert.ToDouble(Reader[6].ToString());
                    order.Received = Convert.ToDouble(Reader[7].ToString());
                    order.OrderChanged = Convert.ToDouble(Reader[8].ToString());
                    order.OrderNo = Convert.ToInt32(Reader[9].ToString());
                    order.CustomerId = Convert.ToInt32(Reader[10].ToString());
                    order.PaymentStatus = Reader[11].ToString();
                    order.Discount = Convert.ToInt32(Reader[12].ToString());
                    orders.Add(order);
                }
                connection.Close();
                return orders;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }
        
        public decimal CalculateDiscountDaily()
        {
            DateTime currentDate = DateTime.Now.Date;
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(discount) FROM tblorders WHERE oDate = @currentDate";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@currentDate", currentDate));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }
        public decimal CalculateTotalDaily()
        {
            DateTime currentDate = DateTime.Now.Date; 
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(total) FROM tblorders WHERE oDate = @currentDate";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@currentDate", currentDate));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }
      
        public decimal CalculateTotalCustomDateRange(DateTime startDate, DateTime endDate)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(total) FROM tblorders WHERE oDate BETWEEN @startDate AND @endDate";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySqlParameter("@startDate", startDate.Date));
                command.Parameters.Add(new MySqlParameter("@endDate", endDate.Date));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }

        public decimal CalculateTotalWeekly()
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime startOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek); // Calculate the start of the current week
            DateTime endOfWeek = startOfWeek.AddDays(6); // Calculate the end of the current week
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(total) FROM tblorders WHERE oDate BETWEEN @startOfWeek AND @endOfWeek";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@startOfWeek", startOfWeek));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@endOfWeek", endOfWeek));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }
        public decimal CalculateTotalMonthly()
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime startOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1); // Calculate the start of the current month
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1); // Calculate the end of the current month
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(total) FROM tblorders WHERE oDate BETWEEN @startOfMonth AND @endOfMonth";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@startOfMonth", startOfMonth));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@endOfMonth", endOfMonth));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }
        public decimal CalculateTotalYearly()
        {
            DateTime currentDate = DateTime.Now.Date;
            DateTime startOfYear = new DateTime(currentDate.Year, 1, 1); // Calculate the start of the current year
            DateTime endOfYear = startOfYear.AddYears(1).AddDays(-1); // Calculate the end of the current year
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(total) FROM tblorders WHERE oDate BETWEEN @startOfYear AND @endOfYear";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@startOfYear", startOfYear));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@endOfYear", endOfYear));

                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }

                connection.Close();
                return 0.00M;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return 0.00M;
            }
        }

        public decimal CalculateTotalSalesUntil(DateTime endDate)
        {
            decimal totalSales = 0m;
            string commandString = @"SELECT SUM(total) AS TotalSales
                             FROM tblorders
                             WHERE oDate < @endDate"; // Orders before the end date (exclusive)

            // Create a new database connection
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();

            // Execute the query and calculate total sales
            try
            {
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@endDate", endDate));

                // Execute the command and read the result
                Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    if (Reader["TotalSales"] != DBNull.Value)
                    {
                        totalSales = Reader.GetDecimal("TotalSales");
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle any exceptions that might occur
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection and reader are properly closed
                Reader?.Close();
                connection.Close();
            }

            return totalSales;
        }


    }
}
