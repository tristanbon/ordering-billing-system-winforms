using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class StaffRoleManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;



        List<StaffRole> role = new List<StaffRole>();


        public void AddRole(string role)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "INSERT INTO staffrole (`role`) VALUES (@role)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("role", role));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Handle the exception here, e.g., log the error or display a message.
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Always close the database connection, even in case of an error.
                connection.Close();
            }
        }

        public void UpdateRole(int id, string role)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                // Specify the table name in the UPDATE statement.
                commandString = "UPDATE `staffrole` SET `role` = @role WHERE `id` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", id));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("role", role));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void DeleteRole(int id)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `staffrole` WHERE `staffrole`.`id` = @id";
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
        public List<StaffRole> GetRoleAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM `staffrole` ORDER BY `staffrole`.`role`";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                role.Clear();
                while (Reader.Read())
                {
                    StaffRole srole = new StaffRole();
                    srole.Id = Convert.ToInt32(Reader[0].ToString());
                    srole.Role = Reader[1].ToString();

                    role.Add(srole);
                }

                connection.Close();
                return role;
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
