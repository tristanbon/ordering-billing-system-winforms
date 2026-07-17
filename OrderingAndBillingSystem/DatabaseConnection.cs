using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OrderingAndBillingSystem
{
    public class DatabaseConnection
    {
        

        public string MyConString;
        public MySqlConnection connection;
        public MySqlCommand dbCommand;

        public DatabaseConnection()
        {
            dbCommand = new MySqlCommand();
        }

        public MySqlConnection connectToDB()
        {
            MyConString = "server=localhost;uid=root;" +
                         "pwd=;"+ ";database=pos;";


            try
            {
                connection = new MySql.Data.MySqlClient.MySqlConnection();
                connection.ConnectionString = MyConString;
                connection.Open();
                return connection;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }

            return connection;
        }
     
    }
}
