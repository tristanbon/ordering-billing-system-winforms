
namespace OrderingAndBillingSystem.Settings
{
    partial class ucSystemInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSystemInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.BusinessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 32);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.btnUpload);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtContact);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtOwnerName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBusinessName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(179, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 499);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 25);
            this.panel2.TabIndex = 474;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUSINESS INFORMATION";
            // 
            // btnNew
            // 
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.Teal;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(67, 310);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 42);
            this.btnNew.TabIndex = 473;
            this.btnNew.Text = "Clear";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.pbImage);
            this.panel6.Location = new System.Drawing.Point(380, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 153);
            this.panel6.TabIndex = 472;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(153, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(21, 21);
            this.btnClear.TabIndex = 533;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Location = new System.Drawing.Point(2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(173, 149);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtAddress.Location = new System.Drawing.Point(169, 257);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(192, 33);
            this.txtAddress.TabIndex = 10;
            // 
            // btnUpload
            // 
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.FillColor = System.Drawing.Color.Teal;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(429, 259);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(88, 35);
            this.btnUpload.TabIndex = 450;
            this.btnUpload.Text = "Browse";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Teal;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(252, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 42);
            this.btnSave.TabIndex = 449;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(29, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address:";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtContact.Location = new System.Drawing.Point(169, 215);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(192, 33);
            this.txtContact.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(29, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Contact No:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(169, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 33);
            this.txtEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(29, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email Address:";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtOwnerName.Location = new System.Drawing.Point(169, 137);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(192, 33);
            this.txtOwnerName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Owner Name:";
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtBusinessName.Location = new System.Drawing.Point(169, 97);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(192, 33);
            this.txtBusinessName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lstInfo);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(3, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 498);
            this.panel4.TabIndex = 450;
            // 
            // lstInfo
            // 
            this.lstInfo.BackColor = System.Drawing.Color.White;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BusinessName});
            this.lstInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstInfo.HideSelection = false;
            this.lstInfo.Location = new System.Drawing.Point(5, 31);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(207, 134);
            this.lstInfo.TabIndex = 3;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            this.lstInfo.Click += new System.EventHandler(this.lstInfo_Click);
            // 
            // BusinessName
            // 
            this.BusinessName.Text = "Business Name";
            this.BusinessName.Width = 200;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(163, 31);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "INFO";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(779, 10);
            this.guna2Separator1.TabIndex = 451;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.ForeColor = System.Drawing.Color.Teal;
            this.panel7.Location = new System.Drawing.Point(172, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 500);
            this.panel7.TabIndex = 473;
            // 
            // ucSystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "ucSystemInfo";
            this.Size = new System.Drawing.Size(779, 505);
            this.Load += new System.EventHandler(this.ucSystemInfo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.ColumnHeader BusinessName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
