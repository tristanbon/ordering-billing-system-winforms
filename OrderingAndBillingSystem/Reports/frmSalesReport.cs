using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Reports
{
    public partial class frmSalesReport : Form
    {
        string ActiveForm = "";

        public frmSalesReport()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlReports.Controls.Clear();
            pnlReports.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void btnAllSales_Click(object sender, EventArgs e)
        {
            ucBestSelling ucb = new ucBestSelling();
            AddUserControl(ucb);
        }
        private void btnBestSell_Click(object sender, EventArgs e)
        {
            ucReports rep = new ucReports();
            AddUserControl(rep);
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            ActiveForm = "ucBestSelling";
            ucBestSelling bes = new ucBestSelling();
            AddUserControl(bes);
        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXreading_Click(object sender, EventArgs e)
        {
            ucX x = new ucX();
            AddUserControl(x);
        }
    }
}
