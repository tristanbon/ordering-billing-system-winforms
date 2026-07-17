using OrderingAndBillingSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Drawing.Printing;

namespace OrderingAndBillingSystem.Model
{
    public partial class Dashboard : Form
    {


        OrderItemsManager itmngr = new OrderItemsManager();
        OrdersManager om = new OrdersManager();

        List<OrderItems> oitm = new List<OrderItems>();
        List<PopularItemList> popularDish = new List<PopularItemList>();
        List<Product> prod = new List<Product>();
        ProductsManager pmgr = new ProductsManager();
        List<Orders> orders = new List<Orders>();

        InfoManager infmngr = new InfoManager();
        Info info = new Info();
        List<Info> infos = new List<Info>();



        public Dashboard()
        {
            InitializeComponent();
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadDailyRevenue();
            GetBestSellingItems();
            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            LoadTotalProducts();
            UpdatePieChart(popularDish);

            LoadSales();
        }


        private void LoadSales()
        {
            orders = om.GetOrdersAll().OrderByDescending(o => o.OrderDate).ToList();
            UpdateSalesGraph(orders);
        }

        private void UpdateSalesGraph(List<Orders> ordersToUpdate)
        {
            chartSales.Series.Clear();
            chartSales.Titles.Clear();

      
            chartSales.Titles.Add("Sales Report");

            // Define the interval for grouping sales data (date, month, or year)
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            var interval = DetermineInterval(startDate, endDate);

            // Group orders by the selected interval and calculate total sales
            var salesData = ordersToUpdate
                .Where(order => order.OrderDate.Date >= startDate && order.OrderDate.Date <= endDate)
                .GroupBy(order => GroupDateTime(order.OrderDate, interval))
                .Select(group => new
                {
                    Interval = group.Key,
                    TotalSales = group.Sum(order => order.Total)
                });

            Series salesSeries = chartSales.Series.FirstOrDefault(s => s.Name == "Total Sales");
            if (salesSeries == null)
            {
                salesSeries = new Series("Total Sales");
                chartSales.Series.Add(salesSeries);
            }

       
            foreach (var data in salesData)
            {
                salesSeries.Points.AddXY(data.Interval, data.TotalSales);
            }
        }


        private string DetermineInterval(DateTime startDate, DateTime endDate)
        {
            if ((endDate - startDate).TotalDays <= 31)
            {
                return "Day";
            }
            else if ((endDate - startDate).TotalDays <= 365)
            {
                return "Month";
            }
            else
            {
                return "Year";
            }
        }

        private DateTime GroupDateTime(DateTime date, string interval)
        {
            if (interval == "Day")
            {
                return date.Date;
            }
            else if (interval == "Month")
            {
                return new DateTime(date.Year, date.Month, 1);
            }
            else // Year
            {
                return new DateTime(date.Year, 1, 1);
            }
        }

        private void UpdateOrdersList(List<Orders> ordersToUpdate)
        {
            lstSales.Items.Clear();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;


            foreach (var order in ordersToUpdate)
            {
                if (order.OrderDate.Date >= startDate && order.OrderDate.Date <= endDate)
                {
                    string onum = order.OrderNo.ToString().PadLeft(3, '0');

                    var lst = new ListViewItem(onum);
                    lst.Tag = order.Id;
                    lst.SubItems.AddRange(new string[]
                    {
                        order.OrderDate.ToShortDateString(),
                        order.Total.ToString("C"),
                        order.Received.ToString("C"),
                        order.OrderChanged.ToString("C"),
                        order.Discount.ToString("C")
                    });
                    lstSales.Items.Add(lst);
                }

            }
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
        }
        private void LoadTotalCustomDateRange(DateTime startDate, DateTime endDate)
        {
            decimal totalSales = om.CalculateTotalCustomDateRange(startDate, endDate);
            lblTotalRevenue.Text = totalSales.ToString("C");
        }
        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            pbOk.Visible = true;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
            DisableCustomDates();

            // Count orders within today's date
            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            GetBestSellingItems();
            UpdatePieChart(popularDish);

            LoadSales();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
            DisableCustomDates();

            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            GetBestSellingItems();
            UpdatePieChart(popularDish);
            LoadSales();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
            DisableCustomDates();

            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            GetBestSellingItems();
            UpdatePieChart(popularDish);

            LoadSales();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
            DisableCustomDates();

            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            GetBestSellingItems();
            UpdatePieChart(popularDish);

            LoadSales();
        }
        private void pbOk_Click(object sender, EventArgs e)
        {
            LoadTotalCustomDateRange(dtpStartDate.Value, dtpEndDate.Value);
            int orderCount = CountOrdersWithinDateRange(dtpStartDate.Value, dtpEndDate.Value);
            lblNumOrders.Text = orderCount.ToString();
            GetBestSellingItems();
            UpdatePieChart(popularDish);

            LoadSales();
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            pbOk.Visible = false;

        }
        private void LoadDailyRevenue()
        {
            decimal dailySales = om.CalculateTotalDaily();
            lblTotalRevenue.Text = dailySales.ToString("C");
        }

        private void GetBestSellingItems()
        {
            try
            {
               
                prod = new ProductsManager().GetProductsAll();

                
                List<OrderItems> orderItems = itmngr.GetOrderItemsAll();

        
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                List<Orders> ordersInRange = new OrdersManager()
                    .GetOrdersAll()
                    .Where(o => o.OrderDate.Date >= startDate && o.OrderDate.Date <= endDate)
                    .OrderByDescending(o => o.OrderDate)
                    .ToList();

                popularDish = new List<PopularItemList>();

                foreach (var product in prod)
                {
                    PopularItemList pdsh = new PopularItemList();
                    int qty = 0;

                    // Join OrderItems with filtered Orders based on OrderId
                    var itemsForProduct = orderItems
                        .Join(ordersInRange,
                              oi => oi.OrderId,
                              o => o.Id,
                              (oi, o) => new { OrderItem = oi, Order = o })
                        .Where(x => x.OrderItem.ProID == product.Id);

                    if (itemsForProduct.Any())
                    {
                        foreach (var item in itemsForProduct)
                        {
                            qty += item.OrderItem.Quantity;
                        }

                        pdsh.ItemImage = product.ItemImage;
                        pdsh.ItemName = product.ItemName;
                        pdsh.Qty = qty;

                        pdsh.Date = itemsForProduct.First().Order.OrderDate;

                        popularDish.Add(pdsh);
                    }
                }

                popularDish = popularDish.OrderByDescending(item => item.Qty).ToList();

                UpdateListView(popularDish);
            }
            catch (Exception ex)
            {
              
                Console.WriteLine(ex.ToString());
            }
        }

        private void UpdateListView(List<PopularItemList> items)
        {
            flpPopulalItem.Controls.Clear(); 

            int rank = 1;

            foreach (var popularItem in items)
            {
               
                ucPopularItem itemControl = new ucPopularItem();

       
                itemControl.ProductImage = System.Drawing.Image.FromStream(new MemoryStream(popularItem.ItemImage));
                itemControl.ItemName = popularItem.ItemName;
                itemControl.TotalItemOrders = Convert.ToInt32(popularItem.Qty.ToString());
                itemControl.Ranking = Convert.ToString(rank).PadLeft(2, '0');


               
                flpPopulalItem.Controls.Add(itemControl);

                rank++;
            }
        }
        public int CountOrdersWithinDateRange(DateTime startDate, DateTime endDate)
        {
            List<Orders> orders = om.GetOrdersAll();

            if (orders != null)
            {
                
                var ordersInRange = orders.Where(o => o.OrderDate.Date >= startDate.Date && o.OrderDate.Date <= endDate.Date);

                int orderCount = ordersInRange.Count();
                return orderCount;
            }
            else
            {
             
                return -1; 
            }
        }

        public void LoadTotalProducts()
        {
            List<Product> products = pmgr.GetProductsAll(); 
            if (products != null)
            {
                int totalProducts = products.Count;
                lblProducts.Text = totalProducts.ToString();
            }
            else
            {
      
                lblProducts.Text = "N/A";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdatePieChart(List<PopularItemList> items)
        {
            chartTopProducts.Series.Clear();
            chartTopProducts.Titles.Clear();

         
            chartTopProducts.Titles.Add("Best Selling Items");

         
            Series series = new Series
            {
                Name = "BestSellingItems",
                ChartType = SeriesChartType.Pie
            };

            // Sort items by quantity and take the top 5
            var topItems = items.OrderByDescending(item => item.Qty).Take(5);

  
            foreach (var item in topItems)
            {
                series.Points.AddXY(item.ItemName, item.Qty);
            }
            chartTopProducts.Series.Add(series);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // You can adjust these margins based on your needs
            int marginX = 50;
            int marginY = 50;

            // Draw the header
            Font headerFont = new Font("Arial", 18, FontStyle.Bold);
            g.DrawString("Dashboard Report", headerFont, Brushes.Black, marginX, marginY);

            // Draw date range
            Font regularFont = new Font("Arial", 12, FontStyle.Regular);
            g.DrawString($"Date From: {dtpStartDate.Value.ToShortDateString()} To: {dtpEndDate.Value.ToShortDateString()}", regularFont, Brushes.Black, marginX, marginY + 40);

            // Draw total sales
            g.DrawString($"Total Sales: {lblTotalRevenue.Text}", regularFont, Brushes.Black, marginX, marginY + 60);

            // Draw total products
            g.DrawString($"Total Products: {lblProducts.Text}", regularFont, Brushes.Black, marginX, marginY + 80);

            // Draw total number of orders
            g.DrawString($"Total Number of Orders: {lblNumOrders.Text}", regularFont, Brushes.Black, marginX, marginY + 100);

            // Add a space between the text and the graphs
            int currentY = marginY + 140;

            // Draw the sales graph
            g.DrawString("Sales Graph:", regularFont, Brushes.Black, marginX, currentY);
            currentY += 20;

            // Draw the sales graph image
            using (MemoryStream chartSalesImageStream = new MemoryStream())
            {
                chartSales.SaveImage(chartSalesImageStream, ChartImageFormat.Png);
                chartSalesImageStream.Position = 0;

                using (System.Drawing.Image chartSalesImage = System.Drawing.Image.FromStream(chartSalesImageStream))
                {
                    g.DrawImage(chartSalesImage, marginX, currentY, 600, 400);
                }
            }
            currentY += 400;

            // Draw the best selling items graph
            g.DrawString("Best Selling Items Graph:", regularFont, Brushes.Black, marginX, currentY);
            currentY += 60;

            // Draw the best-selling items graph image
            using (MemoryStream chartTopProductsImageStream = new MemoryStream())
            {
                chartTopProducts.SaveImage(chartTopProductsImageStream, ChartImageFormat.Png);
                chartTopProductsImageStream.Position = 0;

                using (System.Drawing.Image chartTopProductsImage = System.Drawing.Image.FromStream(chartTopProductsImageStream))
                {
                    g.DrawImage(chartTopProductsImage, marginX, currentY, 500, 400);
                }
            }
            e.Graphics.DrawString("_______________", regularFont, Brushes.Black, new PointF(300, currentY+ 400));
            e.Graphics.DrawString("Prepared by:", regularFont, Brushes.Black, new PointF(330, currentY + 420));
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Set the paper size to A4
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Width = 827, Height = 1169 (in hundredths of an inch)
                                                                                          // Set margins
            printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50); // Left, Right, Top, Bottom margins (in hundredths of an inch
        }

        private void btnPrre_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
}

