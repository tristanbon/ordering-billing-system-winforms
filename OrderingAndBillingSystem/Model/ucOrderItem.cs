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

namespace OrderingAndBillingSystem.View
{
    public partial class ucOrderItem : UserControl
    {
        OrderItemsManager oitm = new OrderItemsManager();

        public ucOrderItem()
        {
            InitializeComponent();            
        }

        public int DetailId { get; set; }
        public string itemName { get; set; }
        public string itemQty { get; set; }
        public string itemPrice { get; set; }
        public string itemSubTotal { get; set; }

      
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; lblItemName.Text = value; }
        }

        public string ItemQty
        {
            get { return itemQty; }
            set { itemQty = value; lblItemQty.Text = value; }
        }

        public string ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; lblItemPrice.Text = value; }
        }

        public string ItemSubTotal
        {
            get { return itemSubTotal; }
            set { itemSubTotal = value; lblItemSubTotal.Text = value; }
        }

             
        public void OrderMouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
            panel1.BackColor = Color.Black;
            panel10.BackColor = Color.Black;
            panel13.BackColor = Color.Black;
            panel14.BackColor = Color.Black;
        }
        private void OrderMouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.BackColor = Color.LightGray;
            panel10.BackColor = Color.LightGray;
            panel13.BackColor = Color.LightGray;
            panel14.BackColor = Color.LightGray;
        }

        private void pnlItem_Click(object sender, EventArgs e)
        {

        }
    }
}
