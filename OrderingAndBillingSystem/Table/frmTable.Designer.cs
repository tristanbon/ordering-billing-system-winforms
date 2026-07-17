
namespace OrderingAndBillingSystem.Table
{
    partial class frmTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTable = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(0, 107);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(867, 400);
            this.pnlTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 52);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table";
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.pnlTable);
            this.pnlReports.Controls.Add(this.panel2);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(867, 507);
            this.pnlReports.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnManage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 107);
            this.panel2.TabIndex = 0;
            // 
            // btnManage
            // 
            this.btnManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManage.Checked = true;
            this.btnManage.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManage.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnManage.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnManage.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManage.FillColor = System.Drawing.Color.White;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManage.Location = new System.Drawing.Point(3, 53);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(202, 51);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Manage Tables";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReports);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTable";
            this.Text = "frmTable";
            this.Load += new System.EventHandler(this.frmTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnManage;
    }
}