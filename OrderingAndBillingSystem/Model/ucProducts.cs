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
   
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
        }
        public event EventHandler EventHndlr = null;

        public string productName { get; set; }
        public Image productImage { get; set; }

        public bool prodStatus { get; set; }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; lblName.Text = value; }
        }

        public Image ProductImage
        {
            get { return productImage; }
            set { productImage = value; pbImage.Image = value; }
        }

        public bool ProdStatus
        {
            get { return prodStatus; }
            set 
            { 
                prodStatus = value;

                if (!prodStatus)
                {
                    pbImage.Controls.Add(pbNotAvailable);
                    pbNotAvailable.BackColor = Color.Transparent;
                    pbNotAvailable.Location = new Point(0, 0);
                    pbNotAvailable.Visible = true;
                    this.Enabled = false;
                }
                else
                {
                    pbNotAvailable.Visible = false;
                    this.Enabled = true;
                }
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            EventHndlr?.Invoke(this, e);
        }

        private void HoverEvent(object sender, EventArgs e)
        {
            pb1.FillColor = Color.Teal;
            pb2.BackColor = Color.Teal;
        }
        private void LeaveEvent(object sender, EventArgs e)
        {
            pb1.FillColor = Color.Gainsboro;
            pb2.BackColor = Color.Gainsboro;
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
            lblName.ForeColor = Color.White;
            lblName.BackColor = Color.Teal;
            pbImage.BackColor = Color.Teal;
            pb2.FillColor = Color.Teal;
            pb2.BackColor = Color.Teal;
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
            lblName.ForeColor = Color.Black;
            lblName.BackColor = Color.White;
            pbImage.BackColor = Color.White;
            pb2.FillColor = Color.White;
            pb2.BackColor = Color.Teal;
        }
    }
}
