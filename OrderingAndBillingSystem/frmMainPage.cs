using OrderingAndBillingSystem.LoginForm;
using OrderingAndBillingSystem.Model;
using OrderingAndBillingSystem.Products;
using OrderingAndBillingSystem.Reports;
using OrderingAndBillingSystem.Settings;
using OrderingAndBillingSystem.Staffs;
using OrderingAndBillingSystem.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem
{
    public partial class frmMainPage : Form
    {
        bool sidebarExpand;
        string ActiveForm = "";

        public frmMainPage()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            ActiveForm = "frmMenuProducts";
            frmMenuProducts menu = new frmMenuProducts();
            menu.MdiParent = this;
            menu.Dock = DockStyle.Fill;
            menu.Show();

        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            ActiveForm = "frmTable";
            frmTable menu = new frmTable();
            menu.MdiParent = this;
            menu.Dock = DockStyle.Fill;
            menu.Show();
        }
      

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ActiveForm = "frmEmployee";
            frmEmployee employee = new frmEmployee();
            employee.MdiParent = this;
            employee.Dock = DockStyle.Fill;
            employee.Show();

            //ActiveForm = "frmStaffEditor";
            //frmStaffEditor staffeditor = new frmStaffEditor();
            //staffeditor.MdiParent = this;
            //staffeditor.Dock = DockStyle.Fill;
            //staffeditor.Show();
        }

        private void frmMainPage_Load(object sender, EventArgs e)
        {
            ActiveForm = "Dashboard";
            Dashboard dash = new Dashboard();
            dash.MdiParent = this;
            dash.Dock = DockStyle.Fill;
            dash.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveForm = "Dashboard";
            Dashboard dash = new Dashboard();
            dash.MdiParent = this;
            dash.Dock = DockStyle.Fill;
            dash.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActiveForm = "frmSalesReports";
            frmSalesReport reports = new frmSalesReport();
            reports.MdiParent = this;
            reports.Dock = DockStyle.Fill;
            reports.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSystemInfo sett = new frmSystemInfo();
            sett.MdiParent = this;
            sett.Dock = DockStyle.Fill;
            sett.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                frmLoginForm frm = new frmLoginForm();
                frm.Show();
            }
        }
    }
}
