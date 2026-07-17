using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class ExpenseManager:DatabaseConnection
    {
        public MySql.Data.MySqlClient.MySqlCommand command;
        public MySql.Data.MySqlClient.MySqlDataReader Reader;

        List<Expenses> expenses = new List<Expenses>();

        public void AddExpense(Expenses exp)
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;
            try
            {
                commandString = "INSERT INTO expenses (date,expenses,receivedby,amount) VALUES (@date,@expenses,@receivedby,@amount)";
                command = connection.CreateCommand();
                command.CommandText = commandString;
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("date", exp.Date));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("expenses", exp.Expense));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("receivedby", exp.ReceivedBy));
                command.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("amount", exp.Amount));
                command.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

            }
            connection.Close();
        }
        public List<Expenses> GetExpenseAll()
        {
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT * FROM expenses";
                command = connection.CreateCommand();
                command.CommandText = commandString;

                MySql.Data.MySqlClient.MySqlDataReader Reader = command.ExecuteReader();

                expenses.Clear();

                while (Reader.Read())
                {
                    Expenses exp = new Expenses();
                    exp.Id = Convert.ToInt32(Reader[0].ToString());
                    exp.Date = Convert.ToDateTime(Reader[1].ToString());
                    exp.Expense = Reader[2].ToString();
                    exp.ReceivedBy = Reader[3].ToString();
                    exp.Amount = Convert.ToDouble(Reader[4].ToString());
                    expenses.Add(exp);
                }
                connection.Close();
                return expenses;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
                return null;
            }
        }
        public decimal CalculateExpenseDaily()
        {
            DateTime currentDate = DateTime.Now.Date;
            DatabaseConnection con = new DatabaseConnection();
            connection = con.connectToDB();
            string commandString;

            try
            {
                commandString = "SELECT SUM(amount) FROM expenses WHERE date = @currentDate";
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
    }
}
