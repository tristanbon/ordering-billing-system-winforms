
namespace OrderingAndBillingSystem.Employee
{
    partial class ucAllEmployeecs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboSearchbyRole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstStaff = new System.Windows.Forms.ListView();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "STAFF LIST";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.cboSearchbyRole);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 49);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cboSearchbyRole
            // 
            this.cboSearchbyRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSearchbyRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboSearchbyRole.FormattingEnabled = true;
            this.cboSearchbyRole.Location = new System.Drawing.Point(697, 8);
            this.cboSearchbyRole.Name = "cboSearchbyRole";
            this.cboSearchbyRole.Size = new System.Drawing.Size(365, 29);
            this.cboSearchbyRole.TabIndex = 7;
            this.cboSearchbyRole.SelectedIndexChanged += new System.EventHandler(this.cboSearchbyRole_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(578, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search by Role:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(90, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 29);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 36);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // StaffName
            // 
            this.StaffName.Text = "Name";
            this.StaffName.Width = 200;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.Width = 200;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 200;
            // 
            // lstStaff
            // 
            this.lstStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StaffName,
            this.Role,
            this.Address,
            this.Phone,
            this.Status});
            this.lstStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstStaff.FullRowSelect = true;
            this.lstStaff.HideSelection = false;
            this.lstStaff.Location = new System.Drawing.Point(3, 99);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(1102, 389);
            this.lstStaff.TabIndex = 11;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1108, 10);
            this.guna2Separator1.TabIndex = 12;
            // 
            // ucAllEmployeecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstStaff);
            this.Name = "ucAllEmployeecs";
            this.Size = new System.Drawing.Size(1108, 488);
            this.Load += new System.EventHandler(this.ucAllEmployeecs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboSearchbyRole;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ListView lstStaff;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
