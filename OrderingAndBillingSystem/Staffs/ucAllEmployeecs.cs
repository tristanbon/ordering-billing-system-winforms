using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Employee
{
    public partial class ucAllEmployeecs : UserControl
    {
        StaffRoleManager rolemngr = new StaffRoleManager();
        StaffsManager smgr = new StaffsManager();

        List<StaffsEmployee> stafs = new List<StaffsEmployee>();
        List<StaffRole> role = new List<StaffRole>();

        StaffsEmployee currStaffs = new StaffsEmployee();

        int rId;
        int sId;

        public ucAllEmployeecs()
        {
            InitializeComponent();
        }
        private void ucAllEmployeecs_Load(object sender, EventArgs e)
        {
            LoadRole();
            GetRole();
            LoadStaff();

        }
        private void LoadStaff()
        {
            stafs = smgr.GetStaffsAll();
            role = rolemngr.GetRoleAll();
            PopulateStaffList();


        }
        private void LoadRole()
        {
            StaffRoleManager rl = new StaffRoleManager();
            role = rl.GetRoleAll();
        }
        private void GetRole()
        {
            cboSearchbyRole.Items.AddRange(role.Select(x => x.Role).ToArray());
        }

        private void PopulateStaffList()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedRole = cboSearchbyRole.SelectedItem as string;

            lstStaff.Items.Clear();


            foreach (StaffsEmployee i in stafs)
            {
                if (i.Name.ToLower().Contains(searchText) &&
                    (string.IsNullOrEmpty(selectedRole) ||
                    (role.FirstOrDefault(c => c.Role == i.Role)?.Role == selectedRole)))
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = i.Name;
                    lst.SubItems.Add(i.Role);
                    lst.SubItems.Add(i.Address);
                    lst.SubItems.Add(i.Phone.ToString());

                    string sStatus = i.Status == 0 ? "Not Active" : "Active";
                    lst.SubItems.Add(sStatus);

                    lstStaff.Items.Add(lst);
                    lst.Tag = i.Id;
                }
               
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateStaffList();
        }

        private void cboSearchbyRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateStaffList();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
