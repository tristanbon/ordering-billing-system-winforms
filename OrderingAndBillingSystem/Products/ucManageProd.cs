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
    public partial class ucManageProd : UserControl
    {
        CategoryManager catmngr = new CategoryManager();
        ProductsManager prodmngr = new ProductsManager();

        List<Category> cat = new List<Category>();
        List<Product> prod = new List<Product>();

        Product currProduct = new Product();
        Category currcat = new Category();

        string filePath;
        public ucManageProd()
        {
            InitializeComponent();
        }
        private void ucManageProd_Load(object sender, EventArgs e)
        {
            LoadCategory();  
            GetCategories(); 
            LoadProducts();
        }
        private void ClearFields()
        {
            pbItemImage.Image = null;
            txtId.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            currProduct = new Product();
        }

        private void LoadProducts()
        {
            Product p = new Product();
            prod = prodmngr.GetProductsAll();
            ClearFields();


            lstProducts.Items.Clear();
            foreach (var i in prod)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.ItemName;
                lst.Tag = i.Id;
                lstProducts.Items.Add(lst);
            }
        }
        private void LoadCategory()
        {
            CategoryManager ct = new CategoryManager();
            cat = ct.GetCategoryAll();
            ClearFields();          
        }
        private void GetCategories()
        {
            cbCategory.Items.AddRange(cat.Select(x => x.Name).ToArray());
            cboSearchbyCate.Items.AddRange(cat.Select(x => x.Name).ToArray());
        }

        private void SetProductsFields()
        {
            currProduct.ItemName = txtProductName.Text;
            currProduct.Price = Convert.ToDouble(txtPrice.Text);
            currProduct.CategoryId = GetCatId(cbCategory.SelectedItem.ToString());
            currProduct.ItemImage = ConvertImage(pbItemImage.Image);
            currProduct.Status = Convert.ToInt32(chkIsActive.Checked);
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
        private int GetCatId(string catname)
        {
            int id = cat.FirstOrDefault(x => x.Name == catname).Id;
            return id;
        }

        private void lstProducts_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count < 1)
                return;

            int selectedProductId = Convert.ToInt32(lstProducts.SelectedItems[0].Tag);
            var selectedItem = prod.FirstOrDefault(x => x.Id == selectedProductId);

            DisplayProductDetails(selectedItem);
        }

        private void DisplayProductDetails(Product product)
        {
            if (product != null)
            {
                ClearFields();

                if (product.ItemImage != null)
                {
                    pbItemImage.Image = Image.FromStream(new MemoryStream(product.ItemImage));
                }

                txtId.Text = product.Id.ToString();
                txtProductName.Text = product.ItemName;
                txtPrice.Text = product.Price.ToString();

                string selectedCategoryName = cat.FirstOrDefault(c => c.Id == product.CategoryId)?.Name;

                if (!string.IsNullOrEmpty(selectedCategoryName))
                {
                    int selectedIndex = cbCategory.FindString(selectedCategoryName);
                    if (selectedIndex != -1)
                    {
                        cbCategory.SelectedIndex = selectedIndex;
                    }
                }

                chkIsActive.Checked = product.Status == 1;

                currProduct = product;
            }
        }

        private void FilterProducts()
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            string selectedCategory = cboSearchbyCate.SelectedItem as string;

            lstProducts.Items.Clear();

            foreach (var product in prod)
            {
                bool matchesSearch = product.ItemName.ToLower().Contains(searchText);
                bool matchesCategory = string.IsNullOrEmpty(selectedCategory) ||
                                      (cat.FirstOrDefault(c => c.Id == product.CategoryId)?.Name == selectedCategory);

                if (matchesSearch && matchesCategory)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = product.ItemName;
                    lst.Tag = product.Id;
                    lstProducts.Items.Add(lst);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void cboSearchbyCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currProduct.Id == 0)
                AddProduct();
            else
                UpdateProduct();
        }
         private void AddProduct()
        {
            try
            {
                if (ValidateInput())
                {
                    SetProductsFields();
                    prodmngr.AddProducts(currProduct);
                    LoadProducts();
                    MessageBox.Show("Product successfully added", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct()
        {
            try
            {   
                if (ValidateInput())
                {
                    SetProductsFields();
                    prodmngr.UpdateProducts(currProduct);
                    LoadProducts();
                    MessageBox.Show("Product successfully updated", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number for the price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (prod.Any(x => x.Id != currProduct.Id && x.ItemName == txtProductName.Text))
            {
                MessageBox.Show("Product name already exists.", "Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image(.jpg, .png)|* .png; * .jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                pbItemImage.Image = new Bitmap(filePath);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currProduct.Id == 0)
            {
                MessageBox.Show("Please select a product");
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you to delete products?",
                                              "Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                prodmngr.DeleteProducts(currProduct);
                LoadProducts();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            pbItemImage.Image = null;
        }
    }
}
