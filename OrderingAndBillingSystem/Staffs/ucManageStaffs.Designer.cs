
namespace OrderingAndBillingSystem.Staffs
{
    partial class ucManageStaffs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManageStaffs));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboSearchbyRole = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstStaff = new System.Windows.Forms.ListView();
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmdClear = new System.Windows.Forms.Button();
            this.pbStaffImg = new System.Windows.Forms.PictureBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(397, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Search by Role:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.cboSearchbyRole);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(241, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 49);
            this.panel3.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(478, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(309, 29);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboSearchbyRole
            // 
            this.cboSearchbyRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboSearchbyRole.FormattingEnabled = true;
            this.cboSearchbyRole.Location = new System.Drawing.Point(165, 8);
            this.cboSearchbyRole.Name = "cboSearchbyRole";
            this.cboSearchbyRole.Size = new System.Drawing.Size(172, 29);
            this.cboSearchbyRole.TabIndex = 8;
            this.cboSearchbyRole.SelectedIndexChanged += new System.EventHandler(this.cboSearchbyRole_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 49);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "STAFF LIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstStaff);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 700);
            this.panel1.TabIndex = 3;
            // 
            // lstStaff
            // 
            this.lstStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StaffName});
            this.lstStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstStaff.HideSelection = false;
            this.lstStaff.Location = new System.Drawing.Point(1, 49);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(226, 447);
            this.lstStaff.TabIndex = 462;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
            this.lstStaff.Click += new System.EventHandler(this.lstStaff_Click);
            // 
            // StaffName
            // 
            this.StaffName.Text = "Name";
            this.StaffName.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(46, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 58);
            this.btnSave.TabIndex = 461;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Teal;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(46, 326);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(205, 58);
            this.guna2Button2.TabIndex = 460;
            this.guna2Button2.Text = "New";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(47, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Full Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(47, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Role:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(45, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Adress:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(47, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Phone:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.Teal;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(571, 388);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(154, 58);
            this.btnBrowse.TabIndex = 450;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtName.Location = new System.Drawing.Point(182, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 33);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtAddress.Location = new System.Drawing.Point(182, 192);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 33);
            this.txtAddress.TabIndex = 453;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(182, 231);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(227, 33);
            this.txtPhone.TabIndex = 454;
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Teal;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(46, 452);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 58);
            this.btnDelete.TabIndex = 459;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.chkIsActive);
            this.panel4.Controls.Add(this.cbRole);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.txtPhone);
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.guna2Button2);
            this.panel4.Controls.Add(this.txtName);
            this.panel4.Controls.Add(this.btnBrowse);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(242, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 629);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(48, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(699, 35);
            this.panel5.TabIndex = 529;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "STAFF INFORMATION";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.chkIsActive.Location = new System.Drawing.Point(327, 285);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(82, 29);
            this.chkIsActive.TabIndex = 528;
            this.chkIsActive.Text = "Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(182, 150);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(227, 33);
            this.cbRole.TabIndex = 526;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.cmdClear);
            this.panel6.Controls.Add(this.pbStaffImg);
            this.panel6.Location = new System.Drawing.Point(460, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(311, 283);
            this.panel6.TabIndex = 527;
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClear.BackColor = System.Drawing.Color.White;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Image = ((System.Drawing.Image)(resources.GetObject("cmdClear.Image")));
            this.cmdClear.Location = new System.Drawing.Point(267, 240);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(41, 40);
            this.cmdClear.TabIndex = 525;
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // pbStaffImg
            // 
            this.pbStaffImg.BackColor = System.Drawing.Color.White;
            this.pbStaffImg.Location = new System.Drawing.Point(3, 2);
            this.pbStaffImg.Name = "pbStaffImg";
            this.pbStaffImg.Size = new System.Drawing.Size(305, 279);
            this.pbStaffImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStaffImg.TabIndex = 491;
            this.pbStaffImg.TabStop = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator2.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1050, 10);
            this.guna2Separator2.TabIndex = 463;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Location = new System.Drawing.Point(236, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 700);
            this.panel7.TabIndex = 529;
            // 
            // ucManageStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "ucManageStaffs";
            this.Size = new System.Drawing.Size(1050, 622);
            this.Load += new System.EventHandler(this.ucManageStaffs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStaffImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.PictureBox pbStaffImg;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ComboBox cboSearchbyRole;
        private System.Windows.Forms.TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
    }
}
