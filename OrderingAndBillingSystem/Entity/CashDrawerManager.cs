using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class CashDrawerManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<CashDrawer> drawer = new List<CashDrawer>();
        public void StartDay(CashDrawer cashdrawer)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO cashdrawer (`date`,`timeStart`,`timeClose`,`startingCash`,`status`) VALUES " +
                    "(@date,@timeStart,@timeClose,@startingCash,@status)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("date", cashdrawer.Date));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("timeStart", cashdrawer.TimeStart));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("timeClose", cashdrawer.TimeClose));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("startingCash", cashdrawer.StartingCash));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("status", cashdrawer.Status));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

        public void EndDay(CashDrawer cashdraw)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = @"Update cashdrawer set  timeClose = @timeClose, status = @status where id = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@timeClose", cashdraw.TimeClose));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@status", cashdraw.Status));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", cashdraw.Id));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public List<CashDrawer> GetDrawer()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                // Get the current date in the required format (assuming MySQL DATE format)
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

                // Modify the SQL query to include a WHERE clause for the current date
                commandString = $"SELECT * FROM cashdrawer WHERE date = '{currentDate}'";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                drawer.Clear();

                while (Reader.Read())
                {
                    CashDrawer cdrawer = new CashDrawer();
                    cdrawer.Id = Convert.ToInt32(Reader[0].ToString());
                    cdrawer.Date = Convert.ToDateTime(Reader[1].ToString());
                    cdrawer.TimeStart = Reader[2].ToString();
                    cdrawer.TimeClose = Reader[3].ToString();
                    cdrawer.StartingCash = Convert.ToDouble(Reader[4].ToString());
                    cdrawer.Status = Reader[5].ToString();

                    drawer.Add(cdrawer); // Add the CashDrawer to the list
                }

                connection.Close();
                return drawer;
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
