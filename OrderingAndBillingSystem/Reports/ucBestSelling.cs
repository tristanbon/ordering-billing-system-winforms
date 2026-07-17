using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace OrderingAndBillingSystem.Reports
{
    public partial class ucBestSelling : UserControl
    {
        List<Orders> orders = new List<Orders>();
        List<OrderItems> oitm = new List<OrderItems>();
        List<PopularItemList> popularDish = new List<PopularItemList>();
        List<Product> prod = new List<Product>();
        OrderItemsManager itmngr = new OrderItemsManager();


        public int currOrderId;

        public int orderId { get; set; }
        public ucBestSelling()
        {
            InitializeComponent();
        }


        private void GetBestSellingItems()
        {
            try
            {
                // Fetch products
                prod = new ProductsManager().GetProductsAll();

                // Fetch order items
                List<OrderItems> orderItems = itmngr.GetOrderItemsAll();

                // Fetch orders within the selected date range
                DateTime startDate = dtStartDate.Value.Date;
                DateTime endDate = dtEndDate.Value.Date;

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

                        pdsh.ItemName = product.ItemName;
                        pdsh.Qty = qty;
                        pdsh.Price = product.Price.ToString();
                        pdsh.Total = qty * Convert.ToDouble(product.Price);
                        pdsh.Date = itemsForProduct.First().Order.OrderDate;

                        popularDish.Add(pdsh);
                    }
                }

                popularDish = popularDish.OrderByDescending(item => item.Qty).ToList();

                // Update the ListView with the filtered data
                UpdateListView(popularDish);
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                Console.WriteLine(ex.ToString());
            }
        }

        private void UpdateListView(List<PopularItemList> items)
        {
            lstSales.Items.Clear(); // Clear existing items

            int rank = 1;

            // Iterate up to the minimum of 10 items or the total number of items, whichever is smaller
            foreach (var popularItem in items)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = Convert.ToString(rank);
                lst.SubItems.Add(popularItem.ItemName);
                lst.SubItems.Add(popularItem.Price.ToString());
                lst.SubItems.Add(popularItem.Qty.ToString());
                lst.SubItems.Add(popularItem.Total.ToString());

                rank++;

                lstSales.Items.Add(lst);
            }
        }

        private void ucBestSelling_Load(object sender, EventArgs e)
        {
            dtEndDate.Value = dtStartDate.Value = DateTime.Today;
            GetBestSellingItems();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            DateTime startDate = dtStartDate.Value.Date;
            DateTime endDate = dtEndDate.Value.Date;
            string dateFormat = "MMMM dd, yyyy";

            lbldtfrom.Visible = true;
            lbldtTo.Visible = true;
            lbldtfrom.Text = startDate.ToString(dateFormat);
            lbldtTo.Text = endDate.ToString(dateFormat);
            GetBestSellingItems();     
        }

        private void printPreviewDialog_Load(object sender, EventArgs e)
        {
            printPreviewDialog.ClientSize = new Size(600, 600);

        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Define fonts
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12, FontStyle.Regular);

            // Define start position and line height
            int startX = 50;
            int startY = 50;
            int lineHeight = 25; // Slightly increased line height for better spacing

            // Define column widths for better alignment
            int rankColumnWidth = 50;
            int itemNameColumnWidth = 300;
            int priceColumnWidth = 100;
            int quantityColumnWidth = 100;
            int totalColumnWidth = 100;

            // Draw title
            e.Graphics.DrawString("Food Items Report", titleFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            e.Graphics.DrawString("GREEN HOUSE RESTO BAR", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            e.Graphics.DrawString("From: " + lbldtfrom.Text, regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            e.Graphics.DrawString("To: " + lbldtTo.Text, regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            // Draw column headers
            e.Graphics.DrawString("Rank", headerFont, Brushes.Black, startX, startY);
            e.Graphics.DrawString("Item Name", headerFont, Brushes.Black, startX + rankColumnWidth, startY);
            e.Graphics.DrawString("Price", headerFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth, startY);
            e.Graphics.DrawString("Quantity", headerFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth + priceColumnWidth, startY);
            e.Graphics.DrawString("Total", headerFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth + priceColumnWidth + quantityColumnWidth, startY);
            startY += lineHeight;

            // Draw sales items
            int rank = 1;
            foreach (var item in popularDish)
            {
                e.Graphics.DrawString(rank.ToString(), regularFont, Brushes.Black, startX, startY);
                e.Graphics.DrawString(item.ItemName, regularFont, Brushes.Black, startX + rankColumnWidth, startY);
                e.Graphics.DrawString(item.Price, regularFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth, startY);
                e.Graphics.DrawString(item.Qty.ToString(), regularFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth + priceColumnWidth, startY);
                e.Graphics.DrawString(item.Total.ToString(), regularFont, Brushes.Black, startX + rankColumnWidth + itemNameColumnWidth + priceColumnWidth + quantityColumnWidth, startY);

                rank++;
                startY += lineHeight; // Move down to the next line
            }
            e.Graphics.DrawString("_______________", regularFont, Brushes.Black, new PointF(300, startY+60));
            e.Graphics.DrawString("Prepared by:", regularFont, Brushes.Black, new PointF(330, startY+80));
        }

        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            // Set the paper size to A4
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169); // Width = 827, Height = 1169 (in hundredths of an inch)
                                                                                          // Set margins
            printDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50); // Left, Right, Top, Bottom margins (in hundredths of an inch
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }
    }
 }