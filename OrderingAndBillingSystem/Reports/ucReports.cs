using OrderingAndBillingSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Reports
{
    public partial class ucReports : UserControl
    {
        List<Orders> orders = new List<Orders>();
        List<OrderItems> items = new List<OrderItems>();
        OrdersManager om = new OrdersManager();
        CustomerManager custmngr = new CustomerManager();
        List<Category> cat = new List<Category>();
        CategoryManager cmngr = new CategoryManager();

        Orders ord = new Orders();


        public ucReports()
        {
            InitializeComponent();
        }

        private void ucReports_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            cmbFilter.SelectedIndex = 0; // Select the first item by default
            LoadSales("Daily"); // Load daily sales by default
        }
        //private void LoadSales()
        //{
        //    orders = om.GetOrdersAll().OrderByDescending(o => o.OrderDate).ToList();
        //    UpdateOrdersList(orders);
        //}

        private void UpdateOrdersList(List<Orders> ordersToUpdate)
        {
            lstSales.Items.Clear();

            foreach (var order in ordersToUpdate)
            {
                string onum = order.OrderNo.ToString().PadLeft(3, '0');

                var lst = new ListViewItem(onum);
                lst.Tag = order.Id;
                lst.SubItems.AddRange(new string[]
                {
            order.OrderDate.ToShortDateString(),
            order.Total.ToString("C"),
            order.Discount.ToString("C")
                });
                lstSales.Items.Add(lst);
            }
        }


        private int pageNumber = 1;
        private int itemsPerPage = 10; // Adjust as needed
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Set up print document layout
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12, FontStyle.Regular);
            float lineHeight = regularFont.GetHeight() + 2;

            // Print selected filter as header
            string selectedFilter = cmbFilter.SelectedItem.ToString();
            string headerText = $"Sales Report ({selectedFilter})";
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, new PointF(100, 20));

            // Print column headers
            e.Graphics.DrawString("Date", regularFont, Brushes.Black, new PointF(100, 60));
            e.Graphics.DrawString("Total", regularFont, Brushes.Black, new PointF(200, 60));
            e.Graphics.DrawString("Discount", regularFont, Brushes.Black, new PointF(500, 60));

            // Draw line separator
            e.Graphics.DrawLine(new Pen(Brushes.Black, 2), 100, 80, 700, 80);

            float yPosition = 90;

            // Print sales details
            int startIndex = (pageNumber - 1) * itemsPerPage;
            for (int i = startIndex; i < orders.Count; i++)
            {
                var order = orders[i];
                e.Graphics.DrawString(order.OrderDate.ToShortDateString(), regularFont, Brushes.Black, new PointF(100, yPosition));
                e.Graphics.DrawString($"₱ {order.Total:F2}", regularFont, Brushes.Black, new PointF(200, yPosition));
                e.Graphics.DrawString($"₱ {order.Discount:F2}", regularFont, Brushes.Black, new PointF(500, yPosition));

                yPosition += lineHeight;

                if (yPosition >= e.MarginBounds.Bottom)
                {
                    // If there are more items to print, set HasMorePages to true
                    pageNumber++;
                    e.HasMorePages = true;
                    return;
                }
            }

            // Print total amount
            e.Graphics.DrawString("Total Amount:", regularFont, Brushes.Black, new PointF(100, yPosition + 20));
            double totalAmount = orders.Sum(order => order.Total);
            e.Graphics.DrawString($"₱ {totalAmount:F2}", regularFont, Brushes.Black, new PointF(200, yPosition + 20));

            e.Graphics.DrawString("_______________", regularFont, Brushes.Black, new PointF(300, yPosition + 90));
            e.Graphics.DrawString("Prepared by:", regularFont, Brushes.Black, new PointF(330, yPosition + 110));
            
            // If there are no more items to print, reset pageNumber and HasMorePages
            pageNumber = 1;
            e.HasMorePages = false;
        }

        private void lstSales_Click(object sender, EventArgs e)
        {
            if (lstSales.SelectedItems.Count < 1)
                return;

            int selectedID = Convert.ToInt32(lstSales.SelectedItems[0].Tag);
            var selectedorder = orders.FirstOrDefault(x => x.Id == selectedID);

            ord = selectedorder;
        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Set the paper size to A4
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Width = 827, Height = 1169 (in hundredths of an inch)
                                                                                          // Set margins
            printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50); // Left, Right, Top, Bottom margins (in hundredths of an inch
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.ClientSize = new Size(600, 600);
        }
        private void LoadSales(string selectedFilter)
        {
            DateTime startDate;
            DateTime endDate;

            switch (selectedFilter)
            {
                case "Daily":
                    startDate = DateTime.Today;
                    endDate = DateTime.Today;
                    break;
                case "Weekly":
                    startDate = DateTime.Today.AddDays(-7);
                    endDate = DateTime.Today;
                    break;
                case "Monthly":
                    startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    break;

                case "Yearly":
                    startDate = new DateTime(DateTime.Today.Year, 1, 1);
                    endDate = new DateTime(DateTime.Today.Year, 12, 31);
                    break;
                default:
                    startDate = DateTime.MinValue;
                    endDate = DateTime.MinValue;
                    break;
            }

            // Filter orders based on the selected date range
            orders = om.GetOrdersAll()
                        .Where(o => o.OrderDate.Date >= startDate && o.OrderDate.Date <= endDate)
                        .OrderByDescending(o => o.OrderDate)
                        .ToList();

            // Update the list view with filtered orders
            UpdateOrdersList(orders);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSales(cmbFilter.SelectedItem.ToString());
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }

}
