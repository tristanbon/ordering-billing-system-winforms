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
    public partial class frmAddQuantity : Form
    {
        public int Quantity { get; set; }

        public frmAddQuantity()
        {
            InitializeComponent();
        }

        private void frmAddQuantity_Load(object sender, EventArgs e)
        {
            if (lblQtyHeader.Text == "Edit Quantity")
                txtQuantity.Text = Convert.ToString(Quantity);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || Convert.ToInt32(txtQuantity.Text) < 1)
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Quantity = quantity;
            DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            txtQuantity.Focus();
            txtQuantity.SelectAll();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int currentQuantity))
            {
                txtQuantity.Text = "1";
                return;
            }

            currentQuantity++;
            txtQuantity.Text = currentQuantity.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int currentQuantity) || Convert.ToInt32(txtQuantity.Text) < 1)
            {
                txtQuantity.Text = "1";
                return;
            }
            else if (Convert.ToInt32(txtQuantity.Text) == 1)
            {
                return;
            }

            currentQuantity--;
            txtQuantity.Text = currentQuantity.ToString();
        }
    }
}
