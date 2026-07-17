using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace OrderingAndBillingSystem.Entity
{
    class CategoryManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Category> categories = new List<Category>();


        public void AddCategory(Category cat)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO category (`catName`,`catImage`) VALUES (@cat,@cImage)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cat", cat.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cImage", cat.CategoryImage));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }

        public void UpdateCategory(Category cat)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "UPDATE category SET `catName` = @cat, `catImage` = @img WHERE `catId` = @id";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id", cat.Id));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cat", cat.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("img", cat.CategoryImage));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        public void DeleteCategory(int id)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "DELETE FROM `category` WHERE `category`.`catId` = @id";
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

        public List<Category> GetCategoryAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM `category` ORDER BY `category`.`catName`";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                categories.Clear();
                while (Reader.Read())
                {
                    Category cat = new Category();
                    cat.Id = Convert.ToInt32(Reader[0].ToString());
                    cat.Name = Reader[1].ToString();
                    if (Reader[2].ToString() != "")
                    {
                        cat.CategoryImage = (byte[])Reader[2];
                    }
                    categories.Add(cat);
                }

                connection.Close();
                return categories;
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
