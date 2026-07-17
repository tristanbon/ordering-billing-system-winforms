using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class Dashboard : DatabaseConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumbProducts { get; set; }
        public List<KeyValuePair<string, int>> RevenueList { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public int NumProducts { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalProfit { get; set; }

        public Dashboard()
        {

        }

        private void GetNumberItems()
        {

            using (var connection = connectToDB())
            {
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(pId) FROM products";
                    NumProducts = (int)command.ExecuteScalar();

                    command.CommandText = @"SELECT COUNT(mainId) FROM tblorders WHERE oDate BETWEEN @fromDate AND @toDate";
                    command.Parameters.AddWithValue("@fromDate", startDate);
                    command.Parameters.AddWithValue("@toDate", endDate);
                    NumOrders = (int)command.ExecuteScalar();
                }
            }


        }
        private void GetOrderAnalysis()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalSales = 0;

            using (var connection = connectToDB())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = @"select oDate, sum(total)
                                            from[tblorders]
                                            where oDate between @fromDate and @toDate
                                            group by oDate";
                    command.Parameters.Add("@fromDate", (MySqlDbType)System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", (MySqlDbType)System.Data.SqlDbType.DateTime).Value = endDate;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalSales += (decimal)reader[1];
                    }
                    TotalProfit = TotalSales * 0.2m;//20%
                    reader.Close();
                    //Group by Hours
                    if (numberDays <= 1)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("hh tt")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                    //Group by Days
                    else if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        private void GetProductAnalysis()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();

            using (var connection = connectToDB())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    MySqlDataReader reader;
                    command.Connection = connection;
                    command.CommandText = @"select top 5 p.pName, sum(tblorderitems.qty) as q from
                      tblorderitems inner join products p on p .proId = tblorderitems.pId
                       inner join [tblorders] o on o.mainId
                        where oDate between @fromDate and @toDate group by p.pName
                        order by q desc";
                    command.Parameters.Add("@fromDate", (MySqlDbType)System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", (MySqlDbType)System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                }
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day,
                endDate.Hour, endDate.Minute, 59);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalysis();
                GetOrderAnalysis();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
