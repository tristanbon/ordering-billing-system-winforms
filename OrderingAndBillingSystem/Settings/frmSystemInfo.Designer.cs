
namespace OrderingAndBillingSystem.Settings
{
    partial class frmSystemInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageDB = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Settings";
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.pnlSettings);
            this.pnlReports.Controls.Add(this.panel2);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(918, 545);
            this.pnlReports.TabIndex = 5;
            this.pnlReports.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReports_Paint);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlSettings.Location = new System.Drawing.Point(0, 107);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(918, 438);
            this.pnlSettings.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnManageDB);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 107);
            this.panel2.TabIndex = 0;
            // 
            // btnManageDB
            // 
            this.btnManageDB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageDB.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManageDB.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnManageDB.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnManageDB.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnManageDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageDB.FillColor = System.Drawing.SystemColors.Control;
            this.btnManageDB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageDB.ForeColor = System.Drawing.Color.Black;
            this.btnManageDB.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManageDB.Location = new System.Drawing.Point(415, 52);
            this.btnManageDB.Name = "btnManageDB";
            this.btnManageDB.Size = new System.Drawing.Size(202, 51);
            this.btnManageDB.TabIndex = 3;
            this.btnManageDB.Text = "Manage Database";
            this.btnManageDB.Click += new System.EventHandler(this.btnManageDB_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdmin.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAdmin.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAdmin.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.SystemColors.Control;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAdmin.Location = new System.Drawing.Point(209, 52);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(202, 51);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfo.Checked = true;
            this.btnInfo.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnInfo.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnInfo.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.SystemColors.Control;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnInfo.ForeColor = System.Drawing.Color.Black;
            this.btnInfo.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnInfo.Location = new System.Drawing.Point(3, 54);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(202, 51);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "System Info";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // frmSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSystemInfo";
            this.Text = "frmSystemInfo";
            this.Load += new System.EventHandler(this.frmSystemInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Button btnManageDB;
    }
}