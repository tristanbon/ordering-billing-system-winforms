using OrderingAndBillingSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Reports
{
    public partial class ucX : UserControl
    {
        OrdersManager om = new OrdersManager();
        OrderItemsManager oitm = new OrderItemsManager();
        List<OrderItems> orderitems = new List<OrderItems>();
        List<Orders> orders = new List<Orders>();
        public ucX()
        {
            InitializeComponent();
        }
        private void ucX_Load(object sender, EventArgs e)
        {
            dtDate.Value = DateTime.Today;
            Loadsales();
        }
        private void Loadsales()
        {
            // Calculate the different types of sales.
            decimal beginningSales = CalculateBeginningSales();
            decimal todaysSales = CalculateTodaysSales();
            decimal endingSales = CalculateEndingSales(beginningSales, todaysSales);

            // Update the labels.
            lblBeginning.Text = beginningSales.ToString("C");
            lblToday.Text = todaysSales.ToString("C");
            lblEnding.Text = endingSales.ToString("C");
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            // Get the selected date from the DateTimePicker control
            DateTime selectedDate = dtDate.Value.Date;

            // Display the selected date in the desired format
            string dateFormat = "MMMM dd, yyyy";
            lbldate.Visible = true;
            lbldate.Text = selectedDate.ToString(dateFormat);

            // Retrieve all orders from the OrdersManager and filter them by the selected date
            List<Orders> ordersAll = om.GetOrdersAll(); // Assuming `om.GetOrdersAll()` returns a list of all orders
            List<Orders> ordersInRange = ordersAll
                .Where(o => o.OrderDate.Date == selectedDate)
                .ToList();

            // Calculate the total sales for the selected date
            double totalSalesForDate = ordersInRange.Sum(order => order.Total);

            // Display the total sales formatted as currency
            lblTotalSales.Text = totalSalesForDate.ToString("C");

            // Retrieve all order items from the OrdersManager
            List<OrderItems> orderItemsAll = oitm.GetOrderItemsAll(); // Assuming `GetOrderItemsAll()` returns a list of all order items

            if (orderItemsAll == null || orderItemsAll.Count == 0)
            {
                // No data retrieved or the list is empty, provide an informative message
                MessageBox.Show("No order items found.");
                return;
            }

            // Use a dictionary for efficient lookups
            HashSet<int> orderIdsInRange = new HashSet<int>(ordersInRange.Select(o => o.Id));

            // Filter order items based on order ID in the filtered orders list and the selected date
            List<OrderItems> orderItemsInRange = orderItemsAll
                .Where(oi => orderIdsInRange.Contains(oi.OrderId))
                .ToList();

            if (orderItemsInRange == null || orderItemsInRange.Count == 0)
            {
                // No data found for the selected date, clear the ListView and provide an informative message
                lstCat.Items.Clear();
                MessageBox.Show($"No order items found for {selectedDate.ToString(dateFormat)}.");
                return;
            }

            // Clear the ListView to prepare for new data
            lstCat.Items.Clear();

            // Group order items by category and calculate totals
            var groupedByCategory = orderItemsInRange
                .GroupBy(oi => oi.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalQuantity = g.Sum(oi => oi.Quantity),
                    TotalAmount = g.Sum(oi => oi.Amount)
                })
                .ToList();

            // Display each group (category) in the ListView
            foreach (var group in groupedByCategory)
            {
                ListViewItem item = new ListViewItem(group.CategoryName);
                item.SubItems.Add(group.TotalQuantity.ToString());
                item.SubItems.Add(group.TotalAmount.ToString("C")); // Format total amount as currency

                lstCat.Items.Add(item);
            }
        }
        private decimal CalculateBeginningSales()
        {
            DateTime today = DateTime.Today;
            // Calculate sales from the beginning of the period to the day before today.
            return om.CalculateTotalSalesUntil(today.AddDays(-1));
        }
        private decimal CalculateTodaysSales()
        {
            // Calculate sales for today.
            return om.CalculateTotalDaily();
        }

        private decimal CalculateEndingSales(decimal beginningSales, decimal todaysSales)
        {
            // Calculate the sum of beginning and today's sales.
            return beginningSales + todaysSales;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Define the start positions and spacing
            int startX = 10;
            int startY = 220; // Initial Y-coordinate for printing list
            int lineSpacing = 30; // Vertical spacing between lines
            int currentY = startY; // Current Y-coordinate to print the list

            // Set the paper size to 58mm width (approximately 2.28 inches)
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);

            // Print header information
            e.Graphics.DrawString("Green House Resto", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Rizal st. Gubat Sorsogon", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(20, 30));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 45));
            e.Graphics.DrawString("X-READING", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 60));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 75));

            // Print date information
            e.Graphics.DrawString("Date:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString(lbldate.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(80, 90));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 100));

            // Print sales summary
            e.Graphics.DrawString("Beginning:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString(lblBeginning.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 120));
            e.Graphics.DrawString("Todays:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString(lblToday.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 140));
            e.Graphics.DrawString("Ending:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString(lblEnding.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 160));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 180));

            // Print Sales Categories header
            e.Graphics.DrawString("Sales Categories", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 210));

            //// Define header for the list of categories
            //e.Graphics.DrawString("Category", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(startX, currentY));
            //e.Graphics.DrawString("Qty", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(startX + 100, currentY));
            //e.Graphics.DrawString("Net Sales", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(startX + 150, currentY));
            //currentY += lineSpacing;

            // Iterate through each item in the list and print the details
            foreach (ListViewItem item in lstCat.Items)
            {
                // Print each item's category name
                e.Graphics.DrawString(item.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX, currentY));

                // Print each item's quantity
                e.Graphics.DrawString(item.SubItems[1].Text+ ".0", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX , currentY+10));

                // Print each item's total amount
                e.Graphics.DrawString(item.SubItems[2].Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, currentY+10));

                // Move to the next line
                currentY += lineSpacing;
            }

            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, currentY));
            e.Graphics.DrawString("Total Net Sales", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(10, currentY + 20));
            e.Graphics.DrawString(lblTotalSales.Text, new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(startX + 120, currentY + 20));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, currentY + 40));

            e.Graphics.DrawString("_______________", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(50, currentY + 60));
            e.Graphics.DrawString("Prepared by:", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(60, currentY + 80));

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
}
