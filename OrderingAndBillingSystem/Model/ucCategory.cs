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
    public partial class ucCategory : UserControl
    {
        public ucCategory()
        {
            InitializeComponent();
        }
        public event EventHandler EventHndlr = null;
        public string categoryName { get; set; }
        public int categoryId { get; set; }
        public Image categoryImage { get; set; }
      
        public bool isBtnClicked { get; set; }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; lblCategory.Text = value; }
        }

        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public Image CategoryImage
        {
            get { return categoryImage; }
            set { categoryImage = value; pbCategoryImg.Image = value; }
        }




        public bool IsBtnClicked
        {
            get { return isBtnClicked; }
            set 
            { 
                isBtnClicked = value;

                if (isBtnClicked)
                {
                    lblCategory.ForeColor = Color.White;
                    lblCategory.BackColor = Color.Teal;
                    pb1.FillColor = Color.Teal;
                    pb2.FillColor = Color.Teal;
                    pb2.BackColor = Color.Teal;
                }
                else
                {
                    lblCategory.ForeColor = Color.Black;
                    lblCategory.BackColor = Color.White;
                    pb1.FillColor = Color.Gainsboro;
                    pb2.FillColor = Color.White;
                    pb2.BackColor = Color.Gainsboro;
                }
            }
        }

        private void ClickEvent(object sender, EventArgs e)
        {

            isBtnClicked = true;

            EventHndlr?.Invoke(this, e);
        }

        private void HoverEvent(object sender, EventArgs e)
        {
            if (isBtnClicked) return;

            lblCategory.BackColor = Color.LightBlue;
            pb1.FillColor = Color.LightBlue;
            pb2.FillColor = Color.LightBlue;
            pb2.BackColor = Color.LightBlue;
        }
        private void LeaveEvent(object sender, EventArgs e)
        {
            if (isBtnClicked) return;

            lblCategory.BackColor = Color.White;
            pb1.FillColor = Color.Gainsboro;
            pb2.FillColor = Color.White;
            pb2.BackColor = Color.Gainsboro;
        }

        private void MouseDownEvent(object sender, MouseEventArgs e)
        {
        }

        private void MouseUpEvent(object sender, MouseEventArgs e)
        {
        }
    }
}
