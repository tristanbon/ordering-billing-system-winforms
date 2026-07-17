using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class CustomerManager : DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Customer> customer = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "Insert into customer (name, phone, address) Values (@name, @phone, @address)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("name", customer.Name));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("phone", customer.Phone));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("address", customer.Address));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }
        public List<Customer> GetCustomerAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "Select * from `customer`";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                customer.Clear();

                while (Reader.Read())
                {
                    Customer cust = new Customer();
                    cust.Id = Convert.ToInt32(Reader[0].ToString());
                    cust.Name = Reader[1].ToString();
                    cust.Phone = Reader[2].ToString();
                    cust.Address = Reader[3].ToString();

                    customer.Add(cust);
                    
                }
                connection.Close();
                return customer;


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
