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

namespace OrderingAndBillingSystem.Staffs
{
    public partial class ucAssignUser : UserControl
    {
        StaffsManager smgr = new StaffsManager();
        UserManager umgr = new UserManager();

        List<StaffsEmployee> stafs = new List<StaffsEmployee>();
        List<Users> users = new List<Users>();

        StaffsEmployee currStaffs = new StaffsEmployee();
        Users user = new Users();

        int uId;


        public ucAssignUser()
        {
            InitializeComponent();
        }

        private void ucAssignUser_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void SetUserFields()
        {
            user.Name = txtName.Text;
            user.Position = cbPosition.SelectedItem.ToString();
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;

        }
        private void ClearFields()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }
        private void LoadStaff()
        {

            stafs = smgr.GetStaffsAll();
            lstStaff.Items.Clear();

            if (stafs is null) return;

            foreach (StaffsEmployee i in stafs)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.Name;
                lstStaff.Items.Add(lst);
                lst.Tag = i.Id;
            }
        }

        private void lstStaff_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedItems.Count < 1)
                return;

            var itm = stafs.Where(x => x.Id == Convert.ToInt32(lstStaff.SelectedItems[0].Tag)).FirstOrDefault();
            txtName.Text = itm.Name.ToString();
            currStaffs = new StaffsEmployee();
            currStaffs.Id = itm.Id;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Id == 0)
                AddUser();
            else
                UpdateUser();
        }
        private void AddUser()
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SetUserFields();
                umgr.AddUser(user);
                ClearFields();
                MessageBox.Show("User Successfully Added", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateUser()
        {
            try
            {
                var i = users.Where(x => x.Id == user.Id);
                if (!i.Any()) return;

                var j = users.Where(x => x.Id != user.Id && x.Name == txtName.Text);
                if (j.Any())
                {
                    MessageBox.Show("User Name already exist", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetUserFields();
                umgr.UpdateUsers(user);
                ClearFields();

                MessageBox.Show("User succesfully Updated", "Product", MessageBoxButtons.OK);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
