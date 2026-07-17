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
        private TextBox activeTextBox; 
        public double amount = 0;
        private bool printReceipt = false;

        public frmPayment()
        {
            InitializeComponent();
            activeTextBox = txtTendered; 
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            string onum = Convert.ToString(Order.CurrentOrder.OrderNo);
            lblOrderNumber.Text = onum.Length < 2 ? "00" + onum : "0" + onum;
            lblTotalAmount.Text = Convert.ToString(Order.CurrentOrder.Total);
            lblOrderType.Text = Order.CurrentOrder.OrderType;
            lblDate.Text = Convert.ToDateTime(Order.CurrentOrder.OrderDate.ToString()).ToShortDateString();
            lblName.Text = Order.CurrentOrder.CustomerName;
        }

        private void NumberOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; 

            if (activeTextBox != null)
            {
                activeTextBox.Text += button.Text; 
            }
        }
        private void txtTendered_Enter(object sender, EventArgs e)
        {
            activeTextBox = txtTendered; 
        }

        private void txtDiscount_Enter(object sender, EventArgs e)
        {
            activeTextBox = txtDiscount; 
        }
    
        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTendered.Text = "";
            txtDiscount.Text = "";
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtChange.Text)|| string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MessageBox.Show("Empty Fields","Warning",MessageBoxButtons.OK);
                return;
            }
            Order.CurrentOrder.Received = Convert.ToDouble(txtTendered.Text);
            Order.CurrentOrder.OrderChanged = Convert.ToDouble(txtChange.Text);
            Order.CurrentOrder.Discount = Convert.ToDouble(txtDiscount.Text);
            printReceipt = chReceipt.Checked;

            DialogResult = DialogResult.OK;

            if (printReceipt)
            {
                RprintPreviewDialog.Document = RprintDocument;
                RprintPreviewDialog.ShowDialog();
            }



            this.Close();
        }

        private void txtTendered_TextChanged(object sender, EventArgs e)
        {
            if (txtTendered.Text == "")
            {
                txtChange.Text = "0";
                return;
            }

            double amntChange = Convert.ToDouble(txtTendered.Text) - Order.CurrentOrder.Total;
            txtChange.Text = Convert.ToString(amntChange);
        }

        private void RprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (!printReceipt)
                return;

            // Fetch items associated with the selected order
            OrderItemsManager itmmngr = new OrderItemsManager();
            List<OrderItems> orderItems = itmmngr.GetOrderItemsByOrderId(Order.CurrentOrder.Id);


            // Print header information
            e.Graphics.DrawString("Green House Resto Bar", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(300, 20));
            e.Graphics.DrawString("1255 Rizal st. Gubat Sorsogon", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(297, 50));

            e.Graphics.DrawString($"Date:{Order.CurrentOrder.OrderDate.ToShortDateString()}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(600, 100));
            e.Graphics.DrawString($"Bill No:{Order.CurrentOrder.OrderNo.ToString("D3")}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString($"Order Type:{Order.CurrentOrder.OrderType}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString($"Customer:{Order.CurrentOrder.CustomerName}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, 140));
            e.Graphics.DrawString($"Table:{Order.CurrentOrder.TableName}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(600, 120));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, 160));

            int yPos = 180;


            // Add header
            e.Graphics.DrawString("Item Name", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString("Quantity", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(250, yPos));
            e.Graphics.DrawString("Price", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(400, yPos));
            e.Graphics.DrawString("Subtotal", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(550, yPos));

            yPos += 20;

            if(orderItems == null)
            {

            }


            //// Print item details
            foreach (var item in orderItems)
            {
                e.Graphics.DrawString(item.ItemName, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, yPos));
                e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(250, yPos));
                e.Graphics.DrawString($"₱ {item.Price}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString($"₱ {item.Quantity * item.Price}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(550, yPos));

                yPos += 20;
            }

            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(25, yPos));


            // Print total amounts
            yPos += 20;
            yPos += 20;
            e.Graphics.DrawString($"Amount to Pay: ₱ {Order.CurrentOrder.Total}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, yPos));
            e.Graphics.DrawString($"Discount: ₱ {Order.CurrentOrder.Discount}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, yPos + 20));
            e.Graphics.DrawString($"Tendered: ₱ {Order.CurrentOrder.Received}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, yPos + 40));
            e.Graphics.DrawString($"Change: ₱ {Order.CurrentOrder.OrderChanged}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, yPos + 60));



            yPos += 100;
            e.Graphics.DrawString("Thank you for coming!", new Font("Arial", 12, FontStyle.Italic), Brushes.Black, new Point(300, yPos));

        }

        private void RprintPreviewDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
