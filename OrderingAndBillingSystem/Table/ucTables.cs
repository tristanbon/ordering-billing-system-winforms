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

namespace OrderingAndBillingSystem.Table
{
    public partial class ucTables : UserControl
    {
        TableManager tabmgr = new TableManager();

        Tables tabs = new Tables();

        List<Tables> table = new List<Tables>();

        int tId;
        public ucTables()
        {
            InitializeComponent();
        }

        private void ucTables_Load(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void ClearFields()
        {
            txtTableName.Clear();
            txtNoOfChairs.Clear();
            tabs = new Tables();
        }
        private void SetFields()
        {
            tabs.TableName = txtTableName.Text;
            tabs.NoOfChairs = Convert.ToInt32(txtNoOfChairs.Text);
        }
        private void LoadTables()
        {
            table = tabmgr.GetTables();

            if (table is null) return;
            lstTable.Items.Clear();
            foreach (Tables i in table)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.TableName;
                lst.SubItems.Add(i.NoOfChairs.ToString());
                lst.Tag = i.Id;
                lstTable.Items.Add(lst);
            }
        }
        private void AddTables()
        {
            try
            {
                if (ValidateInput())
                {
                    SetFields();
                    tabmgr.AddTable(tabs);
                    LoadTables();
                    MessageBox.Show("Tables successfully added", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTables()
        {
            try
            {
                if (ValidateInput())
                {
                    SetFields();
                    tabmgr.UpdateTables(tabs);
                    LoadTables();
                    MessageBox.Show("Tables successfully updated", "Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTableName.Text) || string.IsNullOrWhiteSpace(txtNoOfChairs.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtNoOfChairs.Text, out int chairs))
            {
                MessageBox.Show("Invalid chairs format. Please enter a valid number for the Chairs.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (table.Any(x => x.Id != tabs.Id && x.TableName == txtTableName.Text))
            {
                MessageBox.Show("Table name already exists.", "Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tabs.Id == 0)
                AddTables();
            else
                UpdateTables();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTable.FocusedItem == null)
            {
                MessageBox.Show("There's no selected Table.", "Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lstTable.FocusedItem == null)
            {
                return;
            }
            DialogResult res = MessageBox.Show("Are you sure to delete tables?", "Tables", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                int id = Convert.ToInt32(lstTable.SelectedItems[0].Tag);
                Tables selectedtable = new Tables { Id = id };
                tabmgr.DeleteTables(selectedtable);


                MessageBox.Show("Table Successfully Deleted", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstTable.Items.Clear();
                ClearFields();
                LoadTables();

            }
        }

        private void lstTable_Click(object sender, EventArgs e)
        {
            if (lstTable.SelectedItems.Count < 1)
                return;

            txtTableName.Text = lstTable.FocusedItem.Text;
            tId = Convert.ToInt32(lstTable.SelectedItems[0].Tag.ToString());

            Tables selectedTable = table.FirstOrDefault(t => t.Id == tId);

            if (selectedTable != null)
            {
                tabs.Id = selectedTable.Id; 
                txtNoOfChairs.Text = selectedTable.NoOfChairs.ToString();
            }
        }
    }
}
