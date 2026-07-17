using OrderingAndBillingSystem.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Staffs
{
    public partial class frmEmployee : Form
    {
        string ActiveForm = "";
        public frmEmployee()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlStaffs.Controls.Clear();
            pnlStaffs.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            ActiveForm = "ucManageStaffs";
            ucManageStaffs manage = new ucManageStaffs();
            AddUserControl(manage);
        }
        private void btnAllStaff_Click(object sender, EventArgs e)
        {
            ucManageStaffs manage = new ucManageStaffs();
            AddUserControl(manage);
        }
        private void btnManageStaffs_Click(object sender, EventArgs e)
        {
            ucAllEmployeecs all = new ucAllEmployeecs();
            AddUserControl(all);
        }
      
        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            AllUsers all = new AllUsers();
            AddUserControl(all);
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            ucAssignUser assign = new ucAssignUser();
            AddUserControl(assign);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
