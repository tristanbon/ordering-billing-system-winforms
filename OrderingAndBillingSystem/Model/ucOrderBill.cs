using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.View
{
    public partial class ucOrderBill : UserControl
    {
        public event EventHandler EventHndlr = null;
        public event EventHandler EventHndlrView = null;
        public event EventHandler Pay = null;


        Orders order = new Orders();
        OrdersManager ordrmngr = new OrdersManager();

        public ucOrderBill()
        {
            InitializeComponent();
        }
        private bool isSelected = false;
        public string PaymentStatus
        {
            get { return paymentStatus; }
            set
            {
                paymentStatus = value; lblPaymentStatus.Text = value;
                UpdateBackColor();
            }
        }



        private void UpdateBackColor()
        {
            if (paymentStatus == "Paid")
            {
                pnlOrderPanel.BackColor = Color.FromArgb(207, 253, 225); // Set the color to green for "Paid" status
            }
            else
            {
                // Set the default color for other statuses
                pnlOrderPanel.BackColor = isSelected ? Color.Silver : Color.White;
            }
        }

        public int orderId { get; set; }
        public string table { get; set; }
        public string waiterName { get; set; }
        public string customerName { get; set; }
        public string orderNumber { get; set; }
        public string orderTotalQty { get; set; }
        public string orderTotalPrice { get; set; }
        public string orderOption { get; set; }
        public string paymentStatus { get; set; }
        public string orderDateTime { get; set; }
        public string orderReceived { get; set; }
        public string orderChange { get; set; }
        public string orderDiscount { get; set; }



    

        public bool IsSelected
        {
            get { return isSelected; }
            set 
            { 
                isSelected = value; 

                if (isSelected)
                {
                    pnlOrderPanel.BackColor = Color.Silver;
                    panel3.BackColor = Color.Black;
                    panel4.BackColor = Color.Black;
                    panel5.BackColor = Color.Black;
                    panel9.BackColor = Color.Black;
                    panel13.BackColor = Color.Black;
                    panel22.BackColor = Color.Black;
                    panel30.BackColor = Color.Black;
                    panel29.BackColor = Color.Black;
                }
                else
                {
                    pnlOrderPanel.BackColor = Color.White;
                    panel3.BackColor = Color.LightGray;
                    panel4.BackColor = Color.LightGray;
                    panel5.BackColor = Color.LightGray;
                    panel9.BackColor = Color.LightGray;
                    panel13.BackColor = Color.LightGray;
                    panel22.BackColor = Color.LightGray;
                    panel30.BackColor = Color.LightGray;
                    panel29.BackColor = Color.LightGray;
                }
            }
        }


        public bool orderShow { get; set; }

        public string OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; lblOrderNumber.Text = value; }
        }
        public string Table
        {
            get { return table; }
            set { table = value; lblTable.Text = value; }
        }
   
     
        
        public string OrderTotalQty
        {
            get { return orderTotalQty; }
            set { orderTotalQty = value; lblTotalQty.Text = value; }
        }
        public string OrderTotalPrice
        {
            get { return orderTotalPrice; }
            set { orderTotalPrice = value; lblTotalPrice.Text = value; }
        }

        public string OrderOption
        {
            get { return orderOption; }
            set { orderOption = value; lblOrderOpt.Text = value; }
        }

       
       

        public string OrderDateTime
        {
            get { return orderDateTime; }
            set { orderDateTime = value; lblDateTime.Text = value; }
        }
        public string OrderReceived
        {
            get { return orderReceived; }
            set { orderReceived = value; lblReceived.Text = value; }
        }
        public string OrderChange
        {
            get { return orderChange; }
            set { orderChange = value; lblChange.Text = value; }
        }

        public string OrderDiscount
        {
            get { return orderDiscount; }
            set { orderDiscount = value; lblDiscount.Text = value; }
        }
   

        private void ucOrder_Load(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(pbMore, "Show More");
            tp.SetToolTip(pbLess, "Show Less");
        }

        public void ShowButton()
        {
            if (orderShow)
            {
                pbMore.Visible = false;
                pbLess.Visible = true;
            }
            else
            {
                pbMore.Visible = true;
                pbLess.Visible = false;
            }
        }

        public void LoadItems()
        {
            OrderItemsManager itmmngr = new OrderItemsManager();
            List<OrderItems> oitm = itmmngr.GetOrderItemsAll();
            var itm = oitm.Where(x => x.OrderId == orderId).ToList();

            pnOrderItem.Controls.Clear();

            foreach (var i in itm)
            {
                ucOrderItem lst = new ucOrderItem();

                lst.DetailId = i.ID;
                lst.ItemName = i.ItemName;
                lst.ItemQty = i.Quantity.ToString();
                lst.ItemPrice = "₱ " + i.Price.ToString();
                lst.ItemSubTotal = "₱ " + i.Amount.ToString();
                lst.Width = pnOrderItem.Width;
                pnOrderItem.Controls.Add(lst);       
            }

        }

        public void OrderMouseHover(object sender, EventArgs e)
        {
            //if (isSelected) return;

            //pnlOrderPanel.BackColor = Color.Silver;
            //panel1.BackColor = Color.Black;
            //panel3.BackColor = Color.Black;
            //panel4.BackColor = Color.Black;
            //panel5.BackColor = Color.Black;
            //panel9.BackColor = Color.Black;
            //panel13.BackColor = Color.Black;
            //panel10.BackColor = Color.Black;
            //panel22.BackColor = Color.Black;
            //panel30.BackColor = Color.Black;
            //panel29.BackColor = Color.Black;
        }

        private void OrderMouseLeave(object sender, EventArgs e)
        {
            //if (isSelected) return;

            //pnlOrderPanel.BackColor = Color.White;
            //panel1.BackColor = Color.LightGray;
            //panel3.BackColor = Color.LightGray;
            //panel4.BackColor = Color.LightGray;
            //panel5.BackColor = Color.LightGray;
            //panel9.BackColor = Color.LightGray;
            //panel13.BackColor = Color.LightGray;
            //panel10.BackColor = Color.LightGray;
            //panel22.BackColor = Color.LightGray;
            //panel30.BackColor = Color.LightGray;
            //panel29.BackColor = Color.LightGray;
        }

        private void OrderClickEvent(object sender, EventArgs e)
        {
            isSelected = true; 
            EventHndlr?.Invoke(this, e);
        }

        private void OrderView(object sender, EventArgs e)
        {
            EventHndlrView?.Invoke(this, e);
        }

        private void pnlOrderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
