using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.LoginForm
{
    public partial class frmLoginForm : Form
    {
        InfoManager infmngr = new InfoManager();
        List<Info> infos = new List<Info>();
        UserManager userManager = new UserManager();

        public frmLoginForm()
        {
            InitializeComponent();
 
        }

        private void frmLoginForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
            chPass.Checked = false;
        }
        private void LoadInfo()
        {
            List<Info> infos = infmngr.Getinfo();

            if (infos != null && infos.Count > 0)
            {

                foreach (Info info in infos)
                {

                    if (info.Image != null && info.Image.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(info.Image))
                        {
                            pbImage.Image = Image.FromStream(ms);
                        }
                    }
                }
            }
            else
            {
                // Handle the case where no information was retrieved.
                MessageBox.Show("No information found.");
            }
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure You want to Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateLogin(username, password, out string userRole))
            {
                switch (userRole)
                {
                    case "admin":
                        frmMainPage adminForm = new frmMainPage();
                        adminForm.Show();
                        break;

                    case "cashier":
                        frmPOS userForm = new frmPOS();
                        userForm.Show();
                        break;

                    default:
                        MessageBox.Show("Invalid user role. Please check your credentials.");
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
        private bool ValidateLogin(string username, string password, out string userRole)
        {
            Users user = userManager.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                userRole = user.Position.ToLower();
                return true;
            }

            userRole = null;
            return false;
        }
        private void chPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chPass.Checked ? '\0' : '*';
        }
    }
}

