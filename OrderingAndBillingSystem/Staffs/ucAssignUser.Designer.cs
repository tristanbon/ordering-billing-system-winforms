
namespace OrderingAndBillingSystem.Staffs
{
    partial class ucAssignUser
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
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstStaff = new System.Windows.Forms.ListView();
            this.StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(439, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 58);
            this.btnSave.TabIndex = 454;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.cbPosition);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(244, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 569);
            this.panel3.TabIndex = 453;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(48, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 35);
            this.panel2.TabIndex = 530;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "ASSIGN EMPLOYEE AS A USER/ MANAGE USERS";
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "admin",
            "cashier"});
            this.cbPosition.Location = new System.Drawing.Point(365, 212);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(206, 33);
            this.cbPosition.TabIndex = 452;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtPassword.Location = new System.Drawing.Point(365, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 33);
            this.txtPassword.TabIndex = 451;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label7.Location = new System.Drawing.Point(225, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 450;
            this.label7.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtUserName.Location = new System.Drawing.Point(366, 263);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 33);
            this.txtUserName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(226, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Username:";
            // 
            // btnNew
            // 
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.Teal;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(190, 399);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(205, 58);
            this.btnNew.TabIndex = 449;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(228, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtName.Location = new System.Drawing.Point(365, 148);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 33);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(227, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lstStaff);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 601);
            this.panel1.TabIndex = 456;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lstStaff
            // 
            this.lstStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StaffName});
            this.lstStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstStaff.HideSelection = false;
            this.lstStaff.Location = new System.Drawing.Point(4, 52);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(223, 549);
            this.lstStaff.TabIndex = 462;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
            this.lstStaff.SelectedIndexChanged += new System.EventHandler(this.lstStaff_SelectedIndexChanged);
            this.lstStaff.Click += new System.EventHandler(this.lstStaff_Click);
            // 
            // StaffName
            // 
            this.StaffName.Text = "Name";
            this.StaffName.Width = 150;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 49);
            this.panel4.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "STAFF LIST";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1032, 10);
            this.guna2Separator1.TabIndex = 457;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Location = new System.Drawing.Point(242, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(833, 49);
            this.panel5.TabIndex = 458;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Location = new System.Drawing.Point(235, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 700);
            this.panel6.TabIndex = 459;
            // 
            // ucAssignUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "ucAssignUser";
            this.Size = new System.Drawing.Size(1032, 614);
            this.Load += new System.EventHandler(this.ucAssignUser_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader StaffName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPosition;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
