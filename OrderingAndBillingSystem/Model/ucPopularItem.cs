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
    public partial class ucPopularItem : UserControl
    {
        public ucPopularItem()
        {
            InitializeComponent();
        }

        public string rank { get; set; }
        public int totalItemOrders { get; set; }
        public string itemName { get; set; }
        public Image productImage { get; set; }


        public string Ranking
        {
            get { return rank; }
            set { rank = value; lblRank.Text = value.ToString(); }
        }
        public int TotalItemOrders
        {
            get { return totalItemOrders; }
            set { totalItemOrders = value; lblItemTotalOrders.Text = value.ToString(); }
        }
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; lblItemName.Text = value; }
        }

        public Image ProductImage
        {
            get { return productImage; }
            set { productImage = value; pbImage.Image = value; }
        }


    }
}
