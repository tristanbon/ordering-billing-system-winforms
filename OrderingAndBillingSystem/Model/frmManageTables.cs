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

namespace OrderingAndBillingSystem.Model
{
    public partial class frmManageTables : Form
    {
        TableManager tabmgr = new TableManager();

        Tables tabs = new Tables();

        List<Tables> table = new List<Tables>();

        int tId;
        public frmManageTables()
        {
            InitializeComponent();
        }

        private void frmManageTables_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {

            table = tabmgr.GetTables();

            if (table is null) return;

            foreach(Tables i in table)
            {
                ListViewItem lst = new ListViewItem();
                lst.Text = i.TableName;
                lst.SubItems.Add(i.NoOfChairs.ToString());
                lst.Tag = i.Id;
                lstTable.Items.Add(lst);
            }
        }
        private void ClearFields()
        {
            txtTableName.Clear();
            txtNoOfChairs.Clear();
            tabs = new Tables();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text.Trim() == "")
            {
                MessageBox.Show("Empty input Fields", "Enter valid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtNoOfChairs.Text.Trim() == "")
            {
                MessageBox.Show("Empty input Fields", "Enter valid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!table.Any())
            {
                return;
            }

            var i = table.Where(x => x.TableName == txtTableName.Text);
            if (i.Any())
            {
                MessageBox.Show("Table Name is already exist", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tables tables = new Tables();
                tables.TableName = txtTableName.Text;
                tables.NoOfChairs = Convert.ToInt32(txtNoOfChairs.Text);
                MessageBox.Show("Table Succesfully Added");
                tabmgr.AddTable(tables);
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

            Tables selectedTable= table.FirstOrDefault(t => t.Id == tId);

            if(selectedTable != null)
            {
                txtNoOfChairs.Text = selectedTable.NoOfChairs.ToString();
            }
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
                // Get the selected table's ID from the ListViewItem's Tag
                int id = Convert.ToInt32(lstTable.SelectedItems[0].Tag);
                //tables object with the selected id
                Tables selectedtable = new Tables { Id = id };
                tabmgr.DeleteTables(selectedtable);
         

                MessageBox.Show("Table Successfully Deleted", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lstTable.Items.Clear();
                ClearFields();
                LoadTables();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstTable.FocusedItem == null)
            {
                MessageBox.Show("There's no selected Table.", "Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedTable = table.FirstOrDefault(t => t.Id == tId);

            if (selectedTable != null)
            {
                // Check if the table name already exists (excluding the current table)
                var existingTable = table.FirstOrDefault(t => t.Id != tId && t.TableName == txtTableName.Text);

                if (existingTable != null)
                {
                    MessageBox.Show("Table Name is already exist", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the selected table
                    selectedTable.TableName = txtTableName.Text;
                    selectedTable.NoOfChairs = Convert.ToInt32(txtNoOfChairs.Text);

                    // Call the UpdateTable method to update the table in the database
                    tabmgr.UpdateTables(selectedTable);

                    MessageBox.Show("Table Successfully Updated", "Tables", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear existing data in the ListView
                    lstTable.Items.Clear();
                    ClearFields();
                    // Reload the updated data
                    LoadTables();
                }
            }
        }

      
        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRemove_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
