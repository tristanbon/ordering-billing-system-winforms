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
    public partial class ucAllItems : UserControl
    {
        public ucAllItems()
        {
            InitializeComponent();
        }

       
        public Image productImage { get; set; }
        public string productName { get; set; }
        public string categoryname { get; set; }
        public string price { get; set; }
        public string status { get; set; }

        public Image ProductImage
        {
            get { return productImage; }
            set { productImage = value; pbImage.Image = value; }
        }

        public string Product
        {
            get { return productName; }
            set { productName = value; lblProductName.Text = value; }
        }
        public string Category
        {
            get { return categoryname; }
            set { categoryname = value; lblCategory.Text = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; lblPrice.Text = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; lblStatus.Text = value; }
        }
    }
}
