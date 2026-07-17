using OrderingAndBillingSystem.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Products
{
    public partial class frmMenuProducts : Form
    {
        string ActiveForm = "";
        public frmMenuProducts()
        {
            InitializeComponent();
        }

        private void frmMenuProducts_Load(object sender, EventArgs e)
        {
            ActiveForm = "ucMainProd";
            ucMainProd uc = new ucMainProd();
            AddUserControl(uc);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlProducts.Controls.Clear();
            pnlProducts.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void btnPro_Click(object sender, EventArgs e)
        {
            ucMainProd uc = new ucMainProd();
            AddUserControl(uc);
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ucManageProd manage = new ucManageProd();
            AddUserControl(manage);
        }


        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            ucProList list = new ucProList();
            AddUserControl(list);

        }
    }
}
