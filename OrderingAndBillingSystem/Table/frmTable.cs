using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Table
{
    public partial class frmTable : Form
    {
        string ActiveForm = "";

        public frmTable()
        {
            InitializeComponent();
        }
        private void frmTable_Load(object sender, EventArgs e)
        {
            ActiveForm = "ucTables";
            ucTables manage = new ucTables();
            AddUserControl(manage);
        }
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlTable.Controls.Clear();
            pnlTable.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ucTables manage = new ucTables();
            AddUserControl(manage);
        }  
    }
}
