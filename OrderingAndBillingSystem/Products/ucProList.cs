using OrderingAndBillingSystem.Entity;
using OrderingAndBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OrderingAndBillingSystem.Products
{
    public partial class ucProList : UserControl
    {
        CategoryManager catmngr = new CategoryManager();
        ProductsManager prodmngr = new ProductsManager();

        List<Category> cat = new List<Category>();
        List<Product> prod = new List<Product>();


        public ucProList()
        {
            InitializeComponent();
        }

        private void ucProList_Load(object sender, EventArgs e)
        {
            LoadCategory();
            GetCategories();
            LoadProducts(null);
        }

        private void LoadCategory()
        {
            CategoryManager ct = new CategoryManager();
            cat = ct.GetCategoryAll();
        }

        private void GetCategories()
        {
            cboSearchbyCate.Items.AddRange(cat.Select(x => x.Name).ToArray());
        }

        private void LoadProducts(int? catId)
        {
            prod = prodmngr.GetProductsAll();

            if (catId != null)
            {
                prod = prod.Where(x => x.CategoryId == catId).ToList();
            }
            prod = prod.OrderByDescending(x => x.Status).ToList();

            flpAllProducts.Controls.Clear();
            foreach (var i in prod)
            {
                var categoryName = cat.FirstOrDefault(c => c.Id == i.CategoryId)?.Name;

                ucAllItems lst = new ucAllItems();
                lst.ProductImage = Image.FromStream(new MemoryStream(i.ItemImage));
                lst.Product = i.ItemName;
                lst.Category = categoryName ?? "Unknown Category";
                lst.Price = i.Price.ToString("C");
                lst.Status = i.Status == 1 ? "Available" : "Not Available";

                flpAllProducts.Controls.Add(lst);
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flpAllProducts.Controls)
            {
                var pro = (ucAllItems)item;
                pro.Visible = pro.productName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void cboSearchbyCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cboSearchbyCate.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Find the category ID based on the selected category name
                int categoryId = cat.FirstOrDefault(c => c.Name == selectedCategory)?.Id ?? 0;

                // Load products for the selected category
                LoadProducts(categoryId);
            }
            else
            {
                // If no category is selected, load all products
                LoadProducts(null);
            }
        }
    }
}
