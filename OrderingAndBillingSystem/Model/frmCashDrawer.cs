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

namespace OrderingAndBillingSystem.Model
{
    public partial class frmCashDrawer : Form
    {
        OrdersManager om = new OrdersManager();
        ExpenseManager em = new ExpenseManager();
        CashDrawerManager cdmngr = new CashDrawerManager();
        OrderItemsManager oitm = new OrderItemsManager();
        List<CashDrawer> cashdrawer = new List<CashDrawer>();

        public frmCashDrawer()
        {
            InitializeComponent();
        }
        private void frmCashDrawer_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDaily();
            LoadCashDrawer();
        }

        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDaily()
        {
            decimal discount = om.CalculateDiscountDaily();   
            decimal beginningSales = CalculateBeginningSales();
            decimal todaysSales = CalculateTodaysSales();
            decimal endingSales = CalculateEndingSales(beginningSales, todaysSales);

            // Update the labels.
            txtBeginning.Text = beginningSales.ToString("C");
            txtEnding.Text = endingSales.ToString("C");
            txtDaily.Text = todaysSales.ToString("C");
            txtDiscount.Text = discount.ToString("C");
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

        private void LoadCashDrawer()
        {
            cashdrawer = cdmngr.GetDrawer();

            // Check if there is at least one drawer record
            if (cashdrawer != null && cashdrawer.Count > 0)
            {
                // Assuming you want to display the details of the first drawer in the list
                CashDrawer selectedDrawer = cashdrawer[0];

                // Set the TextBox values based on the selected drawer
                txtTimeStart.Text = selectedDrawer.TimeStart;
                txtTimeClose.Text = selectedDrawer.TimeClose;
                txtStartingCash.Text = selectedDrawer.StartingCash.ToString(); // Convert to string

                // Add similar lines for other TextBoxes as needed
            }
            else
            {
                // Handle the case where no drawer records are available
               
            }
        }



        private void txtTimeStart_MouseClick(object sender, MouseEventArgs e)
        {
        
            DateTime currentTime = DateTime.Now;
            txtTimeStart.Text = currentTime.ToString("HH:mm tt");
        }

        private void txtTimeClose_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtTimeClose.Text = currentTime.ToString("HH:mm tt");
        }

        private void btnStartDay_Click(object sender, EventArgs e)
        {
            CashDrawer cash = new CashDrawer();
            cash.Date = DateTime.Now;
            cash.TimeStart = txtTimeStart.Text;
            cash.TimeClose = txtTimeClose.Text;

            if (double.TryParse(txtStartingCash.Text, out double startingCash))
            {
                cash.StartingCash = startingCash;
            }
            else
            {
                // Handle the case where the text is not a valid double
                MessageBox.Show("Please enter a valid numeric value for starting cash.");
            }
            cash.Status = "Open";

           
            cdmngr.StartDay(cash);
            MessageBox.Show("Start of day process.");
            this.Close();
        }


        private void btnEndDay_Click(object sender, EventArgs e)
        {
            // Check if there is at least one drawer record
            if (cashdrawer != null && cashdrawer.Count > 0)
            {
                // Assuming you want to end the day for the first drawer in the list
                CashDrawer selectedDrawer = cashdrawer[0];

                // Update the TimeClose and Status properties of the selected drawer
                selectedDrawer.TimeClose = txtTimeClose.Text;
                selectedDrawer.Status = "Closed";

                // Call the EndDay method to update the database
                cdmngr.EndDay(selectedDrawer);

                // Optionally, update the UI or perform any other necessary actions
                MessageBox.Show("End of day process completed.");
                this.Close();

                frmPOS frm = new frmPOS();
                frm.btnBill.Enabled = false;

            }
            else
            {
                // Handle the case where no drawer records are available
            }

        }

        private void btnXReading_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            LoadData();



            // Define the start positions and spacing
            int startX = 10;
            int startY = 290; // Initial Y-coordinate for printing list
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
            e.Graphics.DrawString($"{ DateTime.Now.ToShortDateString()}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(120, 90));
            e.Graphics.DrawString("Shift Open:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString(txtTimeStart.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(120, 110));
            e.Graphics.DrawString("Shift Close:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 130));
            e.Graphics.DrawString(txtTimeClose.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(120, 130));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 150));

            // Print sales summary
            e.Graphics.DrawString("Beginning:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString(txtBeginning.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 170));
            e.Graphics.DrawString("Todays:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 190));
            e.Graphics.DrawString(txtDaily.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 190));
            e.Graphics.DrawString("Ending:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 210));
            e.Graphics.DrawString(txtEnding.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, 210));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 230));

            // Print Sales Categories header
            e.Graphics.DrawString("Sales Categories", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(50, 250));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 270));
          
            
            // Iterate through each item in the list and print the details
            foreach (ListViewItem item in lstCat.Items)
            {
                // Print each item's category name
                e.Graphics.DrawString(item.Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX, currentY));

                // Print each item's quantity
                e.Graphics.DrawString(item.SubItems[1].Text + ".0", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX, currentY + 10));

                // Print each item's total amount
                e.Graphics.DrawString(item.SubItems[2].Text, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(startX + 120, currentY + 10));

                // Move to the next line
                currentY += lineSpacing;
            }
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, currentY));
            e.Graphics.DrawString("Total Net Sales", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(10, currentY + 20));
            e.Graphics.DrawString(txtDaily.Text, new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(startX + 120, currentY + 20));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, currentY + 40));

            
     
            e.Graphics.DrawString("_______________", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(50, currentY + 60));
            e.Graphics.DrawString("Prepared by:", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(60, currentY + 80));
        }

        private void LoadData()
        {
            // Retrieve all orders from the OrdersManager and filter them by the selected date
            List<Orders> ordersAll = om.GetOrdersAll(); // Assuming om.GetOrdersAll() returns a list of all orders

            // Filter orders by today's date
            List<Orders> ordersToday = ordersAll
                .Where(o => o.OrderDate.Date == DateTime.Today)
                .ToList();

            // Retrieve all order items from the OrdersManager
            List<OrderItems> orderItemsAll = oitm.GetOrderItemsAll(); // Assuming GetOrderItemsAll() returns a list of all order items

            if (orderItemsAll == null || orderItemsAll.Count == 0)
            {
                // No data retrieved or the list is empty, provide an informative message
                MessageBox.Show("No order items found.");
                return;
            }

            // Use a set to collect order IDs of orders placed today
            HashSet<int> orderIdsToday = new HashSet<int>(ordersToday.Select(o => o.Id));

            // Filter order items based on order ID in the filtered orders list and today's date
            List<OrderItems> orderItemsToday = orderItemsAll
                .Where(oi => orderIdsToday.Contains(oi.OrderId))
                .ToList();

            // Clear the ListView to prepare for new data
            lstCat.Items.Clear();

            // Group order items by category and calculate totals
            var groupedByCategory = orderItemsToday
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
                // Create a new ListViewItem for each group (category)
                ListViewItem item = new ListViewItem(group.CategoryName);

                // Add the total quantity and total amount as subitems
                item.SubItems.Add(group.TotalQuantity.ToString());
                item.SubItems.Add(group.TotalAmount.ToString("C")); // Format total amount as currency

                // Add the item to the ListView
                lstCat.Items.Add(item);
            }
        }
        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
          printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);
        }

    }
}
