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

namespace OrderingAndBillingSystem.Model
{
    public partial class frmPaymentBill : Form
    {
        private TextBox activeTextBox;
        private Orders selectedOrder;
        public int currOrderId;
        public double amount = 0;
        CustomerManager custmngr = new CustomerManager();
        private List<OrderItems> orderItems;
        public frmPaymentBill(Orders currentOrder)
        {
            InitializeComponent();
            activeTextBox = txtTendered;
            Order.CurrentOrder = currentOrder;

            // Set other UI components using selectedOrder
            lblTotalAmount.Text = Convert.ToString(currentOrder.Total);
            LoadOrderItems();

            selectedOrder = currentOrder;

        }
        private void LoadOrderItems()
        {
            OrderItemsManager itmmngr = new OrderItemsManager();
            orderItems = itmmngr.GetOrderItemsByOrderId(Order.CurrentOrder.Id);
        }
        private string GetCustomerName(int id) => custmngr.GetCustomerAll().FirstOrDefault(c => c.Id == id)?.Name;
    

        private void NumberOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (activeTextBox != null)
            {
                activeTextBox.Text += button.Text;
            }
        }
        private void txtTendered_TextChanged_1(object sender, EventArgs e)
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

            double amntChange = Convert.ToDouble(txtTendered.Text) - Order.CurrentOrder.Total;
            txtChange.Text = Convert.ToString(amntChange);
        }

        private void btnPay_Click_1(object sender, EventArgs e)
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

            Orders currentOrder = new Orders();
            Order.CurrentOrder = currentOrder;
            // Update payment details in the selectedOrder
            currentOrder.Received = Convert.ToDouble(txtTendered.Text);
            currentOrder.OrderChanged = Convert.ToDouble(txtChange.Text);
            currentOrder.Discount = Convert.ToDouble(txtDiscount.Text);
            //currentOrder.PaymentStatus = "Paid";


            // Update the order in the database
            OrdersManager ordrmngr = new OrdersManager();
            ordrmngr.UpdateOrder(currentOrder);

            // DialogResult.OK is set only when payment is successful
            DialogResult = DialogResult.OK;    

            
        }

       

      

        private void txtTendered_Enter_1(object sender, EventArgs e)
        {
            activeTextBox = txtTendered;
        }

        private void RprintDocument_PrintPage_1(object sender, PrintPageEventArgs e)
        {    

            string customerName = GetCustomerName(selectedOrder.CustomerId);
            // Set the paper size to typical receipt size (3 inches by 11 inches)
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);

            // Print header information
            e.Graphics.DrawString("Green House Resto", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Rizal st. Gubat Sorsogon", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(20, 30));
            e.Graphics.DrawString($"Date: {selectedOrder.OrderDate.ToShortDateString()}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 45));
            e.Graphics.DrawString($"Order #: {selectedOrder.OrderNo.ToString("D3")}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(60, 60));
            e.Graphics.DrawString($"Table: {selectedOrder.TableName}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(50, 75));
            e.Graphics.DrawString($"{selectedOrder.OrderType}", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(70, 90));
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(10, 105));

            int yPos = 105;
            yPos += 10;
            int totalItems = 0;


            // Print item details
            foreach (var item in orderItems)
            {
                e.Graphics.DrawString(item.ItemName, new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));
                e.Graphics.DrawString(item.Quantity.ToString()+"x", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(15, yPos + 20));
                e.Graphics.DrawString($"₱{item.Price}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(100, yPos + 20));
                e.Graphics.DrawString($"₱{item.Quantity * item.Price}", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(150, yPos + 20));

                yPos += 20;
                totalItems += item.Quantity;
                yPos += 10; // Adjust this value as needed for your spacing
            }

            // Add line separator
            e.Graphics.DrawString("-----------------------------", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos + 5));

            e.Graphics.DrawString($"{totalItems}"+".0", new Font("Courier New", 8, FontStyle.Regular), Brushes.Black, new Point(40, yPos + 15));
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
        }

        private void RprintDocument_BeginPrint_1(object sender, PrintEventArgs e)
        {
            RprintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 500);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTendered.Text))
            {
                txtTendered.Text = txtTendered.Text.Substring(0, txtTendered.Text.Length - 1);
            }

            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                txtDiscount.Text = txtDiscount.Text.Substring(0, txtDiscount.Text.Length - 1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtTendered.Text = "";
            txtDiscount.Text = "";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (activeTextBox != null)
            {
                activeTextBox.Text = ""; // Clear the text of the active text box
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RprintPreviewDialog.Document = RprintDocument;
            RprintPreviewDialog.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
