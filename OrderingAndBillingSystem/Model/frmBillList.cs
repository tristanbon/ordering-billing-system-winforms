using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.View;
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
    public partial class frmBillList : Form
    {
        public string currOrderType = "";
        public string currPaymentStatus = "";
        public int currOrderId;
        public bool fromDash = false;
        private bool mouseDown;
        private Point lastLocation;

        OrdersManager ordrmngr = new OrdersManager();
        List<Orders> ordr = new List<Orders>();

        CustomerManager custmngr = new CustomerManager();
        List<Customer> cust = new List<Customer>();
        OrderItemsManager itmmngr = new OrderItemsManager();
        private int id;

        Orders order = new Orders();

        public frmBillList()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillList_Load(object sender, EventArgs e)
        {    
            LoadOrders();
        }

        private string GetCustomerName(int id)
        {
            Customer c = new Customer();
            cust = custmngr.GetCustomerAll();

            var cname = cust.FirstOrDefault(x => x.Id == id);

            return cname.Name;

        }

        private void LoadOrders(params string[] paymentStatusFilters)
        {
            OrderItemsManager itmmngr = new OrderItemsManager();
            List<OrderItems> oitm = new List<OrderItems>();
            oitm = itmmngr.GetOrderItemsAll();

            DateTime currentDate = DateTime.Now.Date;
            ordr = ordrmngr.GetOrdersAll().OrderBy(i => i.OrderDate).ToList();
            ordr.Reverse();
            pnlBillList.Controls.Clear();

            if (paymentStatusFilters != null && paymentStatusFilters.Length > 0)
            {
                ordr = ordr.Where(x => paymentStatusFilters.Contains(x.PaymentStatus)).ToList();
            }
            else
            {
                // If no paymentStatusFilter is provided, load only pending orders
                ordr = ordr.Where(x => x.PaymentStatus == "Pending").ToList();
            }
            ordr = ordr.OrderByDescending(x => x.PaymentStatus).ToList();

            foreach (var i in ordr)
            {
                if (i.OrderDate.Date == currentDate)
                {
                    ucOrderBill lst = new ucOrderBill();

                    var Totalty = oitm.Where(x => x.OrderId == i.Id).Sum(x => x.Quantity);

                    string onum = i.OrderNo.ToString().Length == 1 ? "00" + i.OrderNo.ToString() :
                                                                      "0" + i.OrderNo.ToString();
                    lst.orderId = i.Id;
                    lst.OrderNumber = onum;
                    lst.Table = i.TableName.ToString();
                    lst.OrderTotalQty = Convert.ToString(Totalty);
                    lst.OrderTotalPrice = "₱ " + i.Total.ToString();
                    lst.OrderOption = i.OrderType.ToString();
                    lst.PaymentStatus = i.PaymentStatus.ToString();
                    lst.OrderDateTime = Convert.ToDateTime(i.OrderDate.ToString()).ToShortDateString();
                    lst.OrderReceived = "₱ " + Convert.ToString(i.Received);
                    lst.OrderChange = "₱ " + Convert.ToString(i.OrderChanged);
                    lst.OrderDiscount = "₱" + Convert.ToString(i.Discount);
                    lst.orderShow = false;
                    lst.Height = 62;
                    lst.Width = pnlBillList.Width - 50;

                    lst.ShowButton();

                    pnlBillList.Controls.Add(lst);

                    currPaymentStatus = "";
                    currOrderId = 0;
                    lst.EventHndlr += (a, b) =>
                    {
                        currPaymentStatus = i.PaymentStatus;
                        currOrderId = i.Id;

                        foreach (var pnl in pnlBillList.Controls)
                        {
                            var p = (ucOrderBill)pnl;
                            if (p.IsSelected) p.IsSelected = false;
                        }

                        foreach (var pnl in pnlBillList.Controls)
                        {
                            var p = (ucOrderBill)pnl;
                            if (p.orderId == i.Id) p.IsSelected = true;
                        }
                    };

                    lst.EventHndlrView += (a, b) =>
                    {
                        var c = (ucOrderBill)a;
                        int cnt = oitm.Where(x => x.OrderId == i.Id).Count();
                        int nhght = 62;

                        nhght = nhght + 60 + (nhght * cnt);

                        if (!c.orderShow)
                        {
                            c.Height = nhght;
                            c.orderShow = true;
                        }
                        else
                        {
                            c.Height = 62;
                            c.orderShow = false;
                        }

                        c.ShowButton();
                        c.LoadItems();
                    };
                }

            }
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Form Drag

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }


        #endregion


      
        private void Validation()
        {
            // From BillList
            if (currOrderId < 1)
            {
                MessageBox.Show("Please select a order to continue.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnPayOrder_Click(object sender, EventArgs e)
        {
            Validation();

            OrdersManager ordmngr = new OrdersManager();
            List<Orders> orders = ordmngr.GetOrdersAll();

            var selectedOrder = orders.FirstOrDefault(x => x.Id == currOrderId);

            if (selectedOrder != null)
            {
                frmPaymentBill frm = new frmPaymentBill(selectedOrder);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    PayOrder(selectedOrder);
                }
            }


        }
        private void PayOrder(Orders orderToUpdate)
        {
            OrdersManager ordrmngr = new OrdersManager();

            if (orderToUpdate != null)
            {
                // Update payment details
                orderToUpdate.Received = Order.CurrentOrder.Received;
                orderToUpdate.OrderChanged = Order.CurrentOrder.OrderChanged;
                orderToUpdate.Discount = Order.CurrentOrder.Discount;
                orderToUpdate.PaymentStatus = "Paid";

                // Update the order in the database
                ordrmngr.UpdateOrder(orderToUpdate);

                // Reload the orders after payment
                LoadOrders();
            }
        }

       
    
        private void btnKOT_Click(object sender, EventArgs e)
        {
            // From BillList
            if (currOrderId < 1)
            {
                MessageBox.Show("Please select a order to continue.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KotprintPreviewDialog.Document = KotprintDocument;
            KotprintPreviewDialog.ShowDialog();
        }

        private void KotprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Fetch details of the selected order
            Orders selectedOrder = ordr.FirstOrDefault(x => x.Id == currOrderId);
            List<OrderItems> orderItems = itmmngr.GetOrderItemsByOrderId(currOrderId);

            string customerName = GetCustomerName(selectedOrder.CustomerId);

            // Set the paper size to typical receipt size (3 inches by 11 inches)
            e.PageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 1100);

            // Print header information
            e.Graphics.DrawString("Kitchen Order Tickets", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString($"Date: {selectedOrder.OrderDate.ToShortDateString()}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 20));
            e.Graphics.DrawString($"Order No: {selectedOrder.OrderNo.ToString()}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString($"Order Type: {selectedOrder.OrderType}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 40));
            e.Graphics.DrawString($"Table: {selectedOrder.TableName}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString($"Customer Name: {customerName}", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, 60));
            e.Graphics.DrawString("-------------------------------------------", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(10, 70));

            int yPos = 90;

            // Add header
            e.Graphics.DrawString("Item Name", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(10, yPos));
            e.Graphics.DrawString("Qty", new Font("Arial", 6, FontStyle.Bold), Brushes.Black, new Point(100, yPos));

            yPos += 10;

            // Print item details
            foreach (var item in orderItems)
            {
                e.Graphics.DrawString(item.ItemName, new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(10, yPos));
                e.Graphics.DrawString(item.Quantity.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(100, yPos));
                yPos += 10;
            }
        }

        private void KotprintDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            KotprintDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 230, 500);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadOrders("Pending", "Paid");
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            LoadOrders("Pending");
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            LoadOrders("Paid");
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            if (currOrderId < 1)
            {
                MessageBox.Show("Please select order to continue.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (currPaymentStatus != "Pending")
            {
                MessageBox.Show("Please select pending order to continue.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //frmPOS frm = new frmPOS();
            //frm.FromDash = true;
            //frm.SlctdOrderId = currOrderId;
            //frm.ShowDialog();

            DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
