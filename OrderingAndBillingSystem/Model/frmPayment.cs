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
    public partial class frmPayment : Form
    {
        List<Product> products = new List<Product>();
        ProductsManager prodmngr = new ProductsManager();

        private TextBox activeTextBox; 
        public double amount = 0;


        private List<OrderItems> selectedOrderItems;

        public frmPayment()
        {
            InitializeComponent();
            activeTextBox = txtTendered;
            selectedOrderItems = new List<OrderItems>();
        }
        public void SetSelectedOrderItems(List<OrderItems> orderItems)
        {
            selectedOrderItems = orderItems;
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
           LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {

            string onum = Convert.ToString(Order.CurrentOrder.OrderNo);
            lblTotalAmount.Text = Convert.ToString(Order.CurrentOrder.Total);

        }


        private void NumberOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 

            if (activeTextBox != null)
            {
                activeTextBox.Text += button.Text; 
            }
        }
      

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if (activeTextBox != null)
            {
                activeTextBox.Text = ""; // Clear the text of the active text box
            }
        }
        

        private void btnPay_Click(object sender, EventArgs e)
        {
            RprintDocument.Print();
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(txtChange.Text) || string.IsNullOrWhiteSpace(txtDiscount.Text) || string.IsNullOrWhiteSpace(txtTendered.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert text values to numbers
            double tenderedAmount, changeAmount, discountAmount;
            if (!double.TryParse(txtTendered.Text, out tenderedAmount) ||
                !double.TryParse(txtChange.Text, out changeAmount) ||
                !double.TryParse(txtDiscount.Text, out discountAmount))
            {
                MessageBox.Show("Invalid input for discount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure tendered amount is not less than total amount
            if (tenderedAmount < Order.CurrentOrder.Total)
            {
                MessageBox.Show("Tendered amount cannot be less than the total amount.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check for character inputs
            if (txtTendered.Text.Any(char.IsLetter) || txtChange.Text.Any(char.IsLetter) || txtDiscount.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Input cannot contain characters. Please enter valid numeric values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Order.CurrentOrder.Received = Convert.ToDouble(txtTendered.Text);
            Order.CurrentOrder.OrderChanged = Convert.ToDouble(txtChange.Text);
            Order.CurrentOrder.Discount = Convert.ToDouble(txtDiscount.Text);
            DialogResult = DialogResult.OK;


            
        }

        private void txtTendered_TextChanged(object sender, EventArgs e)
        {
            if (txtTendered.Text == "")
            {
                txtChange.Text = "0";
                return;
            }

            double tenderedAmount;
            if (!double.TryParse(txtTendered.Text, out tenderedAmount))
            {
                MessageBox.Show("Invalid input for tendered amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          

            // Your remaining code for processing the payment
            double changeAmount = tenderedAmount - Order.CurrentOrder.Total;
            txtChange.Text = changeAmount.ToString();
        }
    
        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            RprintPreviewDialog.Document = RprintDocument;
            RprintPreviewDialog.ShowDialog();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            RprintDocument.Print();
        }
        private void RprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Set the paper size to 58mm width (approximately 2.28 inches)
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);

            // Print header information
            e.Graphics.DrawString("Green House Resto", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Rizal st. Gubat Sorsogon", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(20, 30));
            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 45));
            e.Graphics.DrawString($"Order #: {Order.CurrentOrder.OrderNo.ToString("D3")}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 60));
            e.Graphics.DrawString($"Table: {Order.CurrentOrder.TableName}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(50, 75));
            e.Graphics.DrawString($"{Order.CurrentOrder.OrderType}", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(70, 90));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 105));

            int yPos = 105;
            yPos += 10;
            int totalItems = 0;

            // Print item details
            foreach (var item in selectedOrderItems)
            {
                products = prodmngr.GetProductsAll();
                var product = products.FirstOrDefault(p => p.Id == item.ProID);
                if (product != null)
                {
                    e.Graphics.DrawString(product.ItemName, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));
                    e.Graphics.DrawString(item.Quantity.ToString() + "x", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(15, yPos + 20));
                    e.Graphics.DrawString($"₱{product.Price}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(100, yPos + 20));
                    e.Graphics.DrawString($"₱{item.Amount}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(150, yPos + 20));

                    yPos += 20;
                    totalItems += item.Quantity;
                    yPos += 10; // Adjust this value as needed for your spacing
                }
            }

            // Add line separator
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));

            e.Graphics.DrawString($"{totalItems}" + ".0", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(40, yPos + 15));
            e.Graphics.DrawString($"Item(s)", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(100, yPos + 15));

            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 25));

            // Print total amounts and other details
            yPos += 30;

            e.Graphics.DrawString($"TOTAL:", new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(15, yPos + 5));
            e.Graphics.DrawString($"₱{lblTotalAmount.Text}.00", new Font("Courier New", 9, FontStyle.Bold), Brushes.Black, new Point(120, yPos + 5));

            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 20));

            e.Graphics.DrawString($"PAYMENT RECEIVED:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 30));
            e.Graphics.DrawString($"₱{txtTendered.Text}" + ".00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 30));
            e.Graphics.DrawString($"CHANGE AMOUNT:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 45));
            e.Graphics.DrawString($"₱{txtChange.Text}" + ".00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 45));
            e.Graphics.DrawString($"DISCOUNT:", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 60));
            e.Graphics.DrawString($"₱{txtDiscount.Text}" + ".00", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(130, yPos + 60));

            yPos += 80;

            e.Graphics.DrawString("OFFICIAL RECEIPT", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(40, yPos + 10));
            e.Graphics.DrawString("Thank you for coming!", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(30, yPos + 30));


            //for kot
            e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, yPos + 50));
            // Print header information
            e.Graphics.DrawString("Kitchen Order Tickets", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, yPos + 60));
            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos + 70));
            e.Graphics.DrawString($"Order No: {Order.CurrentOrder.OrderNo.ToString()}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos + 80));
            e.Graphics.DrawString($"Order Type: {Order.CurrentOrder.OrderType}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos + 90));
            e.Graphics.DrawString($"Table: {Order.CurrentOrder.TableName}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos + 100));
            e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, yPos + 110));

            // Reset yPos for printing item details for KOT
            yPos += 120;

            // Add header
            e.Graphics.DrawString("Item Name", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Qty", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(100, yPos));

            yPos += 10;

            // Print item details for KOT
            foreach (var item in selectedOrderItems)
            {
                var product = products.FirstOrDefault(p => p.Id == item.ProID);
                if (product != null)
                {
                    e.Graphics.DrawString(product.ItemName, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                    e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(100, yPos));
                    yPos += 10;
                }         
            }


        }



        private void RprintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            RprintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 550);
        }

        private void txtTendered_Enter_1(object sender, EventArgs e)
        {
            activeTextBox = txtTendered;
        }

        private void txtDiscount_Enter_1(object sender, EventArgs e)
        {
            activeTextBox = txtDiscount;
        }

        private void btnCncel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void RprintPreviewDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
