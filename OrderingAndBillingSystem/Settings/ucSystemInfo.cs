using OrderingAndBillingSystem.Entity;
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

namespace OrderingAndBillingSystem.Settings
{

    public partial class ucSystemInfo : UserControl
    {
        InfoManager infmngr = new InfoManager();
        Info info = new Info();
        List<Info> infos = new List<Info>();

        string filePath;

        public ucSystemInfo()
        {
            InitializeComponent();
        }

        private void ucSystemInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void LoadInfo()
        {
            infos = infmngr.Getinfo();

            lstInfo.Items.Clear();
            foreach(Info i in infos)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.BusinessName;
                lst.Tag = i.Id;
                lstInfo.Items.Add(lst);
            }

        }
        private void btnEnable_Click(object sender, EventArgs e)
        {
            SetFields();
        }

        private void InfoFields()
        {
            info.BusinessName = txtBusinessName.Text;
            info.OwnerName = txtOwnerName.Text;
            info.Email = txtEmail.Text;
            info.Phone = txtContact.Text;
            info.Address = txtAddress.Text;
            info.Image = ConvertImage(pbImage.Image);

        }
        private void SetFields()
        {
            txtBusinessName.Clear();
            txtOwnerName.Clear();
            txtEmail.Clear();
            txtContact.Clear();
            txtAddress.Clear();

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
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(.jpg, .png)|* .png; * .jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pbImage.Image = new Bitmap(filePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (info.Id == 0)
                AddInfo();
            else 
                UpdateInfo();
        }
        private void AddInfo()
        {
            try
            {
                if (ValidateInput())
                {
                    InfoFields();
                    infmngr.AddInfo(info);
                    SetFields();
                    LoadInfo();
                    MessageBox.Show("Save Sucessfully ", "System Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      

        }
        private void UpdateInfo()
        {
            try
            {
                if (ValidateInput())
                {
                    InfoFields();
                    infmngr.UpdateInfo(info);
                    SetFields();
                    LoadInfo();
                    MessageBox.Show("Successfully updated", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBusinessName.Text) || 
                string.IsNullOrWhiteSpace(txtOwnerName.Text) || string.IsNullOrWhiteSpace(txtContact.Text) || 
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void lstInfo_Click(object sender, EventArgs e)
        {
            if (lstInfo.SelectedItems.Count < 1)
                return;

            int selectedInfoId = Convert.ToInt32(lstInfo.SelectedItems[0].Tag);
            var selected = infos.FirstOrDefault(x => x.Id == selectedInfoId);

            DisplayInfoDetails(selected);
        }
        private void DisplayInfoDetails(Info inf)
        {
            if (inf != null)
            {
                //ClearFields();

                if (inf.Image != null)
                {
                    pbImage.Image = Image.FromStream(new MemoryStream(inf.Image));
                }

                txtBusinessName.Text = inf.BusinessName;
                txtOwnerName.Text = inf.OwnerName;
                txtEmail.Text = inf.Email;
                txtContact.Text = Convert.ToString(inf.Phone);
                txtAddress.Text = inf.Address;
                info = inf;
            }
        }

       

  
        private void btnNew_Click(object sender, EventArgs e)
        {
            SetFields();
        }
    }
}
