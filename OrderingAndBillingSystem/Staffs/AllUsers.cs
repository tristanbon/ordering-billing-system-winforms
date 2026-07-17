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

namespace OrderingAndBillingSystem.Staffs
{
    public partial class AllUsers : UserControl
    {
        UserManager umgr = new UserManager();
        List<Users> users = new List<Users>();
        Users user = new Users();

        public AllUsers()
        {
            InitializeComponent();
        }

       
        private void LoadUsers()
        {
           users = umgr.GetUser();

           lstUsers.Items.Clear();
           
            foreach(Users i in users)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.Name;
                lst.SubItems.Add(i.Position);
                lst.SubItems.Add(i.Username);
                lst.Tag = i.Id;
                lstUsers.Items.Add(lst);
            }
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
