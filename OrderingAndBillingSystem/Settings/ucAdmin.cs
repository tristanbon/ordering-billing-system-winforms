 using OrderingAndBillingSystem.Entity;
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
    public partial class ucAdmin : UserControl
    {
        List<Users> users = new List<Users>();
        Users user = new Users();
        UserManager umgr = new UserManager();

        public ucAdmin()
        {
            InitializeComponent();
        }
        
        private void ucAdmin_Load(object sender, EventArgs e)
        {

        }
        private void SetUserFields()
        {
            user.Name = txtName.Text;
            user.Position = txtPosition.Text;
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;

        }
        private void ClearFields()
        {
            txtName.Clear();
            txtPassword.Clear();
            txtUserName.Clear();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (user.Id == 0)
                AddUser();
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
