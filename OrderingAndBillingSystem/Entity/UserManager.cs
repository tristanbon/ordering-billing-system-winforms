using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class UserManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Users> users = new List<Users>();


        public void AddUser(Users user)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO users (`fName`, `position`,`username`,`password`) VALUES (@fName,@position,@username,@password)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("fName", user.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("position", user.Position));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("username", user.Username));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("password", user.Password));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }
        public void UpdateUsers(Users user)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Update users Set fName = @fName, position = @position, username = @username,password =@password where Id = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@fName", user.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@position", user.Position));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@username", user.Username));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@password", user.Password));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", user.Id));

                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public void DeleteUser(Users user)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `users` WHERE `users`.`id` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", user.Id));

                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public List<Users> GetUser()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "Select * from users";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                users.Clear();

                while (Reader.Read())
                {
                    Users user = new Users();
                    user.Id = Convert.ToInt32(Reader[0].ToString());
                    user.Name = Reader[1].ToString();
                    user.Position = Reader[2].ToString();
                    user.Username = Reader[3].ToString();
                    user.Password = Reader[4].ToString();
                    users.Add(user);
                }
                connection.Close();
                return users;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }

        }
        public Users GetUserByUsername(string username)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM users WHERE username = @username";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@username", username));

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    Users user = new Users();
                    user.Id = Convert.ToInt32(Reader[0].ToString());
                    user.Name = Reader[1].ToString();
                    user.Position = Reader[2].ToString();
                    user.Username = Reader[3].ToString();
                    user.Password = Reader[4].ToString();

                    connection.Close();
                    return user;
                }
                else
                {
                    connection.Close();
                    return null; 
                }
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
