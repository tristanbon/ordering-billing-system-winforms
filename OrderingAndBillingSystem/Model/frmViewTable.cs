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
    public partial class frmViewTable : Form
    {
        TableManager tablemngr = new TableManager();
        List<Tables> tab = new List<Tables>();

        public string tableName;
        private bool isSlctd = false;


        Color defaultClr = Color.FromArgb(173, 220, 247);
        Color clckdtClr = Color.FromArgb(59, 154, 209);
        public int id; //04.08.2024
        
        public frmViewTable()
        {
            InitializeComponent();
        }
        private void frmViewTable_Load(object sender, EventArgs e)
        {
            LoadTables();
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
                b.Size = new Size(260, 100);
                b.Text = i.TableName;
                b.Font = new Font("Arial", 12, FontStyle.Regular);

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

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //04.08.2024
            if (tableName is null || isSlctd)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
