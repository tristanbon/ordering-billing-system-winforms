
namespace OrderingAndBillingSystem.Staffs
{
    partial class frmEmployee
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
            this.pnlStaffs = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAssign = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageStaffs = new Guna.UI2.WinForms.Guna2Button();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Size = new System.Drawing.Size(962, 52);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staffs";
            // 
            // pnlReports
            // 
            this.pnlReports.Controls.Add(this.pnlStaffs);
            this.pnlReports.Controls.Add(this.panel2);
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 0);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(962, 535);
            this.pnlReports.TabIndex = 7;
            // 
            // pnlStaffs
            // 
            this.pnlStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaffs.Location = new System.Drawing.Point(0, 110);
            this.pnlStaffs.Name = "pnlStaffs";
            this.pnlStaffs.Size = new System.Drawing.Size(962, 425);
            this.pnlStaffs.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnAssign);
            this.panel2.Controls.Add(this.btnAllUsers);
            this.panel2.Controls.Add(this.btnManageStaffs);
            this.panel2.Controls.Add(this.btnManage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 110);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.Control;
            this.btnAssign.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAssign.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAssign.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnAssign.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAssign.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAssign.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAssign.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAssign.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAssign.FillColor = System.Drawing.SystemColors.Control;
            this.btnAssign.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAssign.ForeColor = System.Drawing.Color.Black;
            this.btnAssign.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAssign.Location = new System.Drawing.Point(419, 55);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(202, 51);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign User";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.BackColor = System.Drawing.SystemColors.Control;
            this.btnAllUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllUsers.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllUsers.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllUsers.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAllUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAllUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllUsers.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllUsers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAllUsers.ForeColor = System.Drawing.Color.Black;
            this.btnAllUsers.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllUsers.Location = new System.Drawing.Point(628, 55);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(202, 51);
            this.btnAllUsers.TabIndex = 4;
            this.btnAllUsers.Text = "All Users";
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // btnManageStaffs
            // 
            this.btnManageStaffs.BackColor = System.Drawing.SystemColors.Control;
            this.btnManageStaffs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageStaffs.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManageStaffs.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnManageStaffs.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnManageStaffs.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnManageStaffs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStaffs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageStaffs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageStaffs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageStaffs.FillColor = System.Drawing.SystemColors.Control;
            this.btnManageStaffs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageStaffs.ForeColor = System.Drawing.Color.Black;
            this.btnManageStaffs.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManageStaffs.Location = new System.Drawing.Point(210, 54);
            this.btnManageStaffs.Name = "btnManageStaffs";
            this.btnManageStaffs.Size = new System.Drawing.Size(202, 51);
            this.btnManageStaffs.TabIndex = 2;
            this.btnManageStaffs.Text = "All Staffs";
            this.btnManageStaffs.Click += new System.EventHandler(this.btnManageStaffs_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnManage.FillColor = System.Drawing.SystemColors.Control;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManage.Location = new System.Drawing.Point(2, 55);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(202, 51);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Manage Staffs";
            this.btnManage.Click += new System.EventHandler(this.btnAllStaff_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlStaffs;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnManageStaffs;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private Guna.UI2.WinForms.Guna2Button btnAllUsers;
        private Guna.UI2.WinForms.Guna2Button btnAssign;
    }
}