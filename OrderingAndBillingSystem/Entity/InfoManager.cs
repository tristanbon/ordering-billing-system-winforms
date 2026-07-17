using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class InfoManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Info> info = new List<Info>();

        public void AddInfo(Info inf)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO info (`businessName`, `ownerName`,`email`,`phone`,`address`, `image`) VALUES (@businessName,@ownerName,@email,@phone,@address,@image)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("businessName", inf.BusinessName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("ownerName", inf.OwnerName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("email", inf.Email));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("phone", inf.Phone));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("address", inf.Address));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("image", inf.Image));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }
        public void UpdateInfo(Info inf)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Update info Set businessName = @businessName, ownerName = @ownerName, email = @email,phone =@phone, address = @address, image = @image where Id = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@businessName", inf.BusinessName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@ownerName", inf.OwnerName));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@email", inf.Email));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@phone", inf.Phone));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@address", inf.Address));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@image", inf.Image));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", inf.Id));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public void DeleteInfo(Info inf)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `info` WHERE `info`.`id` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", inf.Id));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            connection.Close();
        }

        public List<Info> Getinfo()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM info";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                info.Clear();
                while (Reader.Read())
                {
                    Info inf = new Info();
                    inf.Id = Convert.ToInt32(Reader[0].ToString());
                    inf.BusinessName = Reader[1].ToString();
                    inf.OwnerName = Reader[2].ToString();
                    inf.Email = Reader[3].ToString();
                    inf.Phone = Reader[4].ToString();
                    inf.Address = Reader[5].ToString();

                    if (Reader[6].ToString() != "")
                    {
                        inf.Image = (byte[])Reader[6];
                    }

                    info.Add(inf);
                }

                connection.Close();
                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Print the error message.
                connection.Close();
                return null;
            }
        }

    }
}
