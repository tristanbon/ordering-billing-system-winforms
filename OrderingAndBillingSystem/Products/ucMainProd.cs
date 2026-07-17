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

namespace OrderingAndBillingSystem.Products
{
    public partial class ucMainProd : UserControl
    {
        CategoryManager catmngr = new CategoryManager();
        ProductsManager prodmngr = new ProductsManager();

        List<Category> cat = new List<Category>();
        List<Product> prod = new List<Product>();

        Product currProduct = new Product();
        Category currcat = new Category();
        
        int cId;
        string filePath;
        public ucMainProd()
        {
            InitializeComponent();
        }
        private void ucMainProd_Load(object sender, EventArgs e)
        {
            LoadCategory();
           
        }
      
        private void LoadCategory()
        {
            CategoryManager ct = new CategoryManager();
            cat = ct.GetCategoryAll();

          
            lstCategory.Items.Clear();
            foreach (Category i in cat)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.Name;
                lst.Tag = i.Id;
                lstCategory.Items.Add(lst);
            }
        }

        private void lstCategory_Click(object sender, EventArgs e)
        {
            if (lstCategory.SelectedItems.Count < 1)
                return;

            int selectedCategoryId = Convert.ToInt32(lstCategory.SelectedItems[0].Tag);
            var selectedCat = cat.FirstOrDefault(x => x.Id == selectedCategoryId);

            if (selectedCat != null && selectedCat.CategoryImage != null)
            {
                pbCategoryImg.Image = Image.FromStream(new MemoryStream(selectedCat.CategoryImage));
            }
            else
            {
                pbCategoryImg.Image = null;
            }

            txtCategory.Text = lstCategory.FocusedItem.Text;
            currcat = selectedCat;
            cId = selectedCategoryId;

        
        }

      
        private void SetCategoryFields()
        {
            currcat.Name = txtCategory.Text;
            currcat.CategoryImage = ConvertImage(pbCategoryImg.Image);
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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(.jpg, .png)|* .png; * .jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pbCategoryImg.Image = new Bitmap(filePath);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            pbCategoryImg.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text.Trim() == "")
            {
                MessageBox.Show("Please enter category.", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!cat.Any())
            {
                return;
            }

            if (lstCategory.SelectedItems.Count < 1)
            {
                var i = cat.Where(x => x.Name == txtCategory.Text);
                if (i.Any())
                {
                    MessageBox.Show("Category already exist.", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SetCategoryFields();
                    catmngr.AddCategory(currcat);
                    txtCategory.Clear();
                    pbCategoryImg.Image = null;
                    LoadCategory();

                    MessageBox.Show("Category Succesfully Added");
                }
            }
            else
            {
                if (lstCategory.FocusedItem == null)
                {
                    MessageBox.Show("There's no selected category.", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var i = cat.Where(x => x.Id != cId && x.Name == txtCategory.Text);
                if (i.Any())
                {
                    MessageBox.Show("Category already exist.", "Category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SetCategoryFields();
                    pbCategoryImg.Image = null;
                    catmngr.UpdateCategory(currcat);
                    txtCategory.Clear();
                    LoadCategory();

                    MessageBox.Show("Category Succesfully Updated");
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (lstCategory.FocusedItem == null)
            {
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you to delete category?" +
                                               "\nItems under the selected category will be also deleted", "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                catmngr.DeleteCategory(cId);
                txtCategory.Clear();
                pbCategoryImg.Image = null;
                LoadCategory();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbCategoryImg.Image = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            lstCategory.Items.Clear();

            foreach (var cate in cat)
            {
                if (cate.Name.ToLower().Contains(searchText))
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = cate.Name;
                    lst.Tag = cate.Id;
                    lstCategory.Items.Add(lst);
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
