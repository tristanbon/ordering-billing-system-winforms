using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class TableManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Tables> tables = new List<Tables>();

        public List<Tables> GetTables()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "Select * from tables";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                tables.Clear();

                while (Reader.Read())
                {
                    Tables tab = new Tables();
                    tab.Id = Convert.ToInt32(Reader[0].ToString());
                    tab.TableName = Reader[1].ToString();
                    tab.NoOfChairs = Convert.ToInt32(Reader[2].ToString());
                    tab.Status = Convert.ToInt32(Reader[3].ToString());
                    tables.Add(tab);
                }

                connection.Close();
                return tables;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }
        public void AddTable(Tables table)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO tables (tname, tchairs, status) VALUES (@name, @chairs, @status)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@name", table.TableName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@chairs", table.NoOfChairs));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@status", table.Status));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

       
        public void UpdateTables(Tables table)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Update tables Set tname = @name, tchairs = @tchairs, status = @status where tId = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@name", table.TableName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@tchairs", table.NoOfChairs));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@status", table.Status));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", table.Id));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public void DeleteTables(Tables tables)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `tables` WHERE `tables`.`tId` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", tables.Id));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            connection.Close();
        }

    }
}
