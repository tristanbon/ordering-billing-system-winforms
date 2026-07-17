using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OrderingAndBillingSystem.Settings
{
    public partial class ucManageDB : UserControl
    {
        public ucManageDB()
        {
            InitializeComponent();
            connString = "server=localhost;uid=root;pwd=skAte_12;database=pos_app;";
            con = new MySqlConnection(connString);
        }

        string path;
        string connString;
        MySqlConnection con;
        void backgroundaction()
        {
            if (txtPath.Text != "")
            {
                ProgressBar.Visible = true;
                lbllast.Visible = true;
                backgroundWorker1.RunWorkerAsync();

            }
            else
            {
                MessageBox.Show("Place is empty");
                return;
            }

        }

        private void lblBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rdoBackup.Checked == true)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "database file(*.sql)|*sql";
                savefile.FilterIndex = 2;
                savefile.DefaultExt = "sql";
                savefile.RestoreDirectory = true;
                savefile.Title = "save database file";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    path = savefile.FileName;
                    txtPath.Text = path;
                }
            }
            if (rdoRestore.Checked == true)
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Title = "open database file";
                openfile.Filter = "database file(*.sql)|*sql";
                openfile.FilterIndex = 2;
                openfile.RestoreDirectory = true;
                openfile.DefaultExt = "sql";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    path = openfile.FileName;
                    txtPath.Text = path;
                }
            }
        }
        void action()
        {
            if (rdoBackup.Checked)
            {
                backup();
            }
            else if (rdoRestore.Checked)
            {
                restore();
            }
        }
        MySqlBackup mb1;

        private void btnPoced_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @DatabaseName";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DatabaseName", txtDatabase.Text);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    if (!string.IsNullOrEmpty(txtPath.Text))
                    {
                        backgroundaction();
                    }
                    else
                    {
                        MessageBox.Show("Please provide a path for backup.");
                    }
                }
                else
                {
                    MessageBox.Show("Database does not exist.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        void backup()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = con;
                    con.Open();
                    mb.ExportProgressChanged += backup_progresschange; // Subscribe to progress changed event
                    mb.ExportCompleted += backup_completed; // Subscribe to completed event
                    mb.ExportToFile(path);
                    con.Close();
                }
            }
        }
        void backup_progresschange(object sender, ExportProgressArgs e)
        {
            double percentage = (double)e.CurrentTableIndex / (double)e.TotalTables * 100;
            string progressMessage = $"{e.CurrentTableIndex} of {e.TotalTables} Tables Backup Completed ({percentage:0.00}%).";

            // Update the progress label and progress bar
            if (lbllast.InvokeRequired)
            {
                lbllast.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbllast.Text = progressMessage;
                });
            }
            else
            {
                lbllast.Text = progressMessage;
            }

            ProgressBar.Maximum = e.TotalTables;
            ProgressBar.Value = e.CurrentTableIndex;

        }
        private void backup_completed(object sender, ExportCompleteArgs e)
        {
            MessageBox.Show("Succsefully Backuped");
        }
        void restore()
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                using (MySqlBackup mb = new MySqlBackup(cmd))
                {
                    cmd.Connection = con;
                    con.Open();

                    // Subscribe to the progress changed event
                    mb.ImportProgressChanged += restore_progresschange;

                    // Start the restore operation
                    mb.ImportFromFile(path);
                    con.Close();
                }
            }
            MessageBox.Show("Restore completed successfully.");
        }

        static double ConvertByteToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }


        private void restore_progresschange(object sender, ImportProgressArgs e)
        {
            double progressPercentage = (double)e.CurrentBytes / (double)e.TotalBytes * 100;
            string progressMessage = $"Progress: {progressPercentage:0.00}% Completed.\n" +
                                     $"Bytes Read: {ConvertByteToMegabytes(e.CurrentBytes):0.000} MB " +
                                     $"out of {ConvertByteToMegabytes(e.TotalBytes):0.000} MB.";

            // Update the progress label and progress bar
            if (lbllast.InvokeRequired)
            {
                lbllast.BeginInvoke((MethodInvoker)delegate ()
                {
                    lbllast.Text = progressMessage;
                });
            }
            else
            {
                lbllast.Text = progressMessage;
            }

            ProgressBar.Value = (int)progressPercentage;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            action();   
        }

        private void ucManageDB_Load(object sender, EventArgs e)
        {
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
            ProgressBar.Value = 0;
        }
    }
}
