using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class StaffsManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<StaffsEmployee> staffs = new List<StaffsEmployee>();
        public void AddStaff(StaffsEmployee staf)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO staffs (`name`, `role`,`address`,`phone`,`image`, `status`) VALUES (@name,@role,@address,@phone,@image,@status)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("name", staf.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("role", staf.Role));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("address", staf.Address));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("phone", staf.Phone));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("image", staf.Image));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("status", staf.Status));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

        public void UpdateStaffs(StaffsEmployee staf)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Update staffs Set name = @name, role = @role, address = @address,phone =@phone, image = @img, status = @status where Id = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@name", staf.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@role", staf.Role));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@address", staf.Address));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@phone", staf.Phone));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@img", staf.Image));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@status", staf.Status));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("@id", staf.Id));

                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        public void DeleteStaffs(StaffsEmployee stafs)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `staffs` WHERE `staffs`.`id` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", stafs.Id));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
            connection.Close();
        }

        public List<StaffsEmployee> GetStaff()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "Select * from staffs where role = 'Waiter'";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                staffs.Clear();

                while (Reader.Read())
                {
                    StaffsEmployee staf = new StaffsEmployee();
                    staf.Id = Convert.ToInt32(Reader[0].ToString());
                    staf.Name = Reader[1].ToString();


                    staffs.Add(staf);
                }
                connection.Close();
                return staffs;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }

        public List<StaffsEmployee> GetStaffsAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM `staffs` ORDER BY `staffs`.`name`";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                staffs.Clear();
                while (Reader.Read())
                {
                    StaffsEmployee staff = new StaffsEmployee();
                    staff.Id = Convert.ToInt32(Reader[0].ToString());
                    staff.Name = Reader[1].ToString();
                    staff.Role = Reader[2].ToString();
                    staff.Address = Reader[3].ToString();
                    staff.Phone = Reader[4].ToString();

                    if (Reader[5].ToString() != "")
                    {
                        staff.Image = (byte[])Reader[5];
                    }

                    staff.Status = Convert.ToInt32(Reader[6].ToString());

                    staffs.Add(staff);
                }

                connection.Close();
                return staffs;
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
