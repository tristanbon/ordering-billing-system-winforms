using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Settings
{
    public partial class frmSystemInfo : Form
    {
        string ActiveForm = "";
        public frmSystemInfo()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlSettings.Controls.Clear();
            pnlSettings.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void frmSystemInfo_Load(object sender, EventArgs e)
        {
            ActiveForm = "ucSystemInfo";
            ucSystemInfo ucinfo = new ucSystemInfo();
            AddUserControl(ucinfo);
        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ucSystemInfo ucinfo = new ucSystemInfo();
            AddUserControl(ucinfo);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ucAdmin admin = new ucAdmin();
            AddUserControl(admin);
        }

        private void btnManageDB_Click(object sender, EventArgs e)
        {
            ucManageDB db = new ucManageDB();
            AddUserControl(db);
        }
    }
}
