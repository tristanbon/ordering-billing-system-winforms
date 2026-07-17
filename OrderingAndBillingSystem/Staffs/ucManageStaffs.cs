using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Staffs
{
    public partial class ucManageStaffs : UserControl
    {
        StaffRoleManager rolemngr = new StaffRoleManager();
        StaffsManager smgr = new StaffsManager();

        List<StaffsEmployee> stafs = new List<StaffsEmployee>();
        List<StaffRole> role = new List<StaffRole>();

        StaffsEmployee currStaffs = new StaffsEmployee();

        int rId;
        int sId;

        string filePath;

        public ucManageStaffs()
        {
            InitializeComponent();
        }
       

        private void ucManageStaffs_Load(object sender, EventArgs e)
        {
            LoadRole();
            LoadStaff();
        }
        private void ClearFields()
        {
            pbStaffImg.Image = null;
            txtName.Clear();
            cbRole.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            currStaffs = new StaffsEmployee();
        }
        private void SetStaffFields()
        {
            currStaffs.Name = txtName.Text;
            currStaffs.Role = cbRole.SelectedItem.ToString();
            currStaffs.Address = txtAddress.Text;
            currStaffs.Phone = txtPhone.Text;
            currStaffs.Image = ConvertImage(pbStaffImg.Image);
            currStaffs.Status = Convert.ToInt32(chkIsActive.Checked);
        }
        private byte[] ConvertImage(Image itmImg)
        {
            if (itmImg is null) return null;

            byte[] imgArr = null;
            Image img = new Bitmap(itmImg);
            MemoryStream mstrm = new MemoryStream();
            img.Save(mstrm, ImageFormat.Png);
            imgArr = mstrm.ToArray();

            return imgArr;
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

     

        private void LoadRole()
        {
            
            role = rolemngr.GetRoleAll();
            cboSearchbyRole.Items.Clear();
            cbRole.Items.Clear();

            foreach (StaffRole i in role)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.Role;
                lst.Tag = i.Id;
                cbRole.Items.Add(i.Role);
                cboSearchbyRole.Items.Add(i.Role);
            }

        }


        private void lstStaff_Click(object sender, EventArgs e)
        {
            if (lstStaff.SelectedItems.Count < 1)
                return;

            var itm = stafs.Where(x => x.Id == Convert.ToInt32(lstStaff.SelectedItems[0].Tag)).FirstOrDefault();

            pbStaffImg.Image = null;
            if (itm.Image != null && itm.Image.Count() > 0)
            {
                pbStaffImg.Image = Image.FromStream(new MemoryStream(itm.Image));
            }

            txtName.Text = itm.Name.ToString();
            cbRole.SelectedIndex = cbRole.FindString(itm.Role);
            txtAddress.Text = itm.Address.ToString();
            txtPhone.Text = itm.Phone.ToString();
            chkIsActive.Checked = Convert.ToBoolean(itm.Status);

            currStaffs = new StaffsEmployee();
            currStaffs.Id = itm.Id;
            SetStaffFields();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(.jpg, .png)|* .png; * .jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pbStaffImg.Image = new Bitmap(filePath);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currStaffs.Id == 0)
                AddStaff();
            else
                UpdateStaff();
        }
        private void AddStaff()
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || cbRole.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               

                var existingStaff = stafs.FirstOrDefault(s => s.Id != sId && s.Name == txtName.Text);
                if (existingStaff != null)
                {
                    MessageBox.Show("Staff Name already exist.", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetStaffFields();
                smgr.AddStaff(currStaffs);
                ClearFields();
                MessageBox.Show("Staff Successfully Added", "Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaff();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStaff()
        {
            try
            {
                var i = stafs.Where(x => x.Id == currStaffs.Id);
                if (!i.Any()) return;

                var j = stafs.Where(x => x.Id != currStaffs.Id && x.Name == txtName.Text);
                if (j.Any())
                {
                    MessageBox.Show("Staff Name already exist", "Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SetStaffFields();
                smgr.UpdateStaffs(currStaffs);
                ClearFields();

                MessageBox.Show("Staff succesfully Updated", "Product", MessageBoxButtons.OK);
                LoadStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save");
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            pbStaffImg.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currStaffs.Id == 0)
            {
                MessageBox.Show("Please select a Staff");
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you to delete staff?",
                                             "Staffs", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                smgr.DeleteStaffs(currStaffs);
                LoadStaff();
            }
            ClearFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateStaffList();
        }

        private void cboSearchbyRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStaffList();
        }

        private void UpdateStaffList()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedRole = cboSearchbyRole.SelectedItem as string;

            lstStaff.Items.Clear();

            foreach (var staff in stafs)
            {
                if ((string.IsNullOrEmpty(searchText) || staff.Name.ToLower().Contains(searchText)) &&
                    (string.IsNullOrEmpty(selectedRole) || staff.Role == selectedRole))
                {
                    AddStaffToList(staff);
                }
            }
        }

        private void AddStaffToList(StaffsEmployee staff)
        {
            ListViewItem lst = new ListViewItem();
            lst.Text = staff.Name;
            lst.SubItems.Add(staff.Role);
            lst.SubItems.Add(staff.Address);
            lst.SubItems.Add(staff.Phone.ToString());

            string sStatus = staff.Status == 0 ? "Not Active" : "Active";
            lst.SubItems.Add(sStatus);

            lstStaff.Items.Add(lst);
            lst.Tag = staff.Id;
        }
        
    }
}
