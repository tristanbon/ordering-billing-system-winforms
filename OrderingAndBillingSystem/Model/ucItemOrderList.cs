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
    public partial class ucItemOrderList : UserControl
    {
        public event EventHandler RemoveItemClicked;
        public event EventHandler UpdateItemClicked;

        public ucItemOrderList()
        {
            InitializeComponent();
        }
        public string itmName { get; set; }

        public string price { get; set; }

        public string quantity { get; set; }

        public string amount { get; set; }
        public string status { get; set; } 

        public string ItemName
        {
            get { return itmName; }
            set { itmName = value; lblItemName.Text = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; lblPrice.Text = value; }
        }
        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; lblqty.Text = value; }
        }
        public string Amount
        {
            get { return amount; }
            set { amount = value; lblAmount.Text = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            if (status != "Done")
            {
                RemoveItemClicked?.Invoke(this, EventArgs.Empty);
            }

        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            UpdateItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ucItemOrderList_Load(object sender, EventArgs e)
        {
            //ToolTip tp = new ToolTip();
            //tp.IsBalloon = true;
            //tp.SetToolTip(btnUpdate, "Update Quantity");
            //tp.SetToolTip(btnRemove, "Remove Item");
        }
    }
}
