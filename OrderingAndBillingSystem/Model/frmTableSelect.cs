using Guna.UI2.WinForms;
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
    public partial class frmTableSelect : Form
    {   
        StaffsManager smngr = new StaffsManager();
        TableManager tablemngr = new TableManager();

        List<StaffsEmployee> staf = new List<StaffsEmployee>();
        List<Tables> tab = new List<Tables>();
        
        public string tableName;
        public string sName;

        public int id; //04.08.2024
        private bool isSlctd = false;
        
        
        Color defaultClr = Color.FromArgb(173, 220, 247);
        Color clckdtClr = Color.FromArgb(59, 154, 209);

        public frmTableSelect()
        {
            InitializeComponent();
        }

       private void LoadTables()
        {
            flpTable.Controls.Clear();
            lblNotif.Visible = false;

            tab = tablemngr.GetTables();

            if (tab is null)
            {
                MessageBox.Show("There's no existing table(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            foreach (Tables i in tab)
            {
                Guna2Button b = new Guna2Button();
                b.BorderRadius = 5;
                //b.BorderThickness = 1;
                b.Size = new Size(90, 70);
                b.Text = i.TableName;
                //b.BackColor = Color.White;
                b.ForeColor = Color.Black;
                b.Tag = i.Id;

                //04.08.2024
                if (i.Status == 1)
                {
                    //b.Enabled = false;
                    b.FillColor = Color.Gainsboro;
                }
                else
                {
                    //b.Enabled = true;
                    b.FillColor = defaultClr;
                }

                b.Click += new EventHandler(TableClick);
                b.DoubleClick += new EventHandler(UpdateSelectedTable);
                flpTable.Controls.Add(b);

            }
        }

        private void LoadStaff()
        {
            staf = smngr.GetStaff();

            if (staf is null)
            {
                MessageBox.Show("There's no existing staff(s).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            foreach (StaffsEmployee i in staf)
            {
                Guna2Button b = new Guna2Button();
                b.BorderRadius = 5;
                b.Size = new Size(175, 45);
                b.Text = i.Name;
                b.FillColor = defaultClr;
                b.ForeColor = Color.Black;
                //b.BackColor = Color.White;
                b.Tag = i.Id;

                b.Click += new EventHandler(WaiterClick);
                flpWaiter.Controls.Add(b);
            }
        }


        private void TableClick(object sender, EventArgs e)
        {
            //04.08.2024
            //(sender as Button).BackColor = Color.Gainsboro;

            isSlctd = (sender as Guna2Button).FillColor == Color.Gainsboro ? true : false;
            lblNotif.Visible = isSlctd ? true : false;

            tableName = (sender as Guna2Button).Text;
            id = Convert.ToInt32((sender as Guna2Button).Tag);


            foreach (Guna2Button pnl in flpTable.Controls)
            {
                if (pnl.FillColor != Color.Gainsboro)
                {
                    pnl.FillColor = defaultClr;
                }
            }

            if (isSlctd) return;

            (sender as Guna2Button).FillColor = clckdtClr;
        }

       
        private void WaiterClick(object sender, EventArgs e)
        {
            sName = (sender as Guna2Button).Text.ToString();

            //04.08.2024
            //(sender as Button).BackColor = Color.Teal;
            //(sender as Button).ForeColor = Color.White;


            foreach (Guna2Button pnl in flpWaiter.Controls)
            {
                pnl.FillColor = defaultClr;
            }

            (sender as Guna2Button).FillColor = clckdtClr;
        }
        //04.08.2024
        private void UpdateSelectedTable(object sender, EventArgs e)
        {
            try
            {
                if (!isSlctd)
                {
                    return;
                }

                DialogResult dgResult = MessageBox.Show("Enable selected table?", "Table Availability", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dgResult == DialogResult.Yes)
                {
                    var tblData = tablemngr.GetTables();
                    var curr = tblData.FirstOrDefault(x => x.Id == id);
                    if (curr != null)
                    {
                        curr.Status = 0;
                        tablemngr.UpdateTables(curr);

                        LoadTables();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmTableSelect_Load(object sender, EventArgs e)
        {
            LoadTables();
            LoadStaff();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //04.08.2024
            if (tableName is null || sName is null || isSlctd)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }


        private void pbRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
