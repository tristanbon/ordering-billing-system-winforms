namespace OrderingAndBillingSystem.Settings
{
    partial class ucManageDB
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPoced = new Guna.UI2.WinForms.Guna2Button();
            this.lbllast = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBrowse = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoRestore = new System.Windows.Forms.RadioButton();
            this.rdoBackup = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnPoced);
            this.panel3.Controls.Add(this.lbllast);
            this.panel3.Controls.Add(this.ProgressBar);
            this.panel3.Controls.Add(this.txtDatabase);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 499);
            this.panel3.TabIndex = 452;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 30);
            this.panel5.TabIndex = 461;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "BACKUP/RESTORE DATABASE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 29);
            this.panel1.TabIndex = 460;
            // 
            // btnPoced
            // 
            this.btnPoced.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPoced.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPoced.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPoced.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPoced.FillColor = System.Drawing.Color.Teal;
            this.btnPoced.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPoced.ForeColor = System.Drawing.Color.White;
            this.btnPoced.Location = new System.Drawing.Point(392, 202);
            this.btnPoced.Name = "btnPoced";
            this.btnPoced.Size = new System.Drawing.Size(129, 38);
            this.btnPoced.TabIndex = 482;
            this.btnPoced.Text = "Proceed";
            this.btnPoced.Click += new System.EventHandler(this.btnPoced_Click);
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.Location = new System.Drawing.Point(51, 258);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(16, 21);
            this.lbllast.TabIndex = 480;
            this.lbllast.Text = "..";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(42, 299);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(344, 11);
            this.ProgressBar.TabIndex = 479;
            this.ProgressBar.Text = "guna2ProgressBar1";
            this.ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.ProgressBar.Visible = false;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabase.Location = new System.Drawing.Point(157, 122);
            this.txtDatabase.Multiline = true;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(171, 20);
            this.txtDatabase.TabIndex = 478;
            this.txtDatabase.Text = "pos_app";
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblBrowse);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtPath);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rdoRestore);
            this.panel2.Controls.Add(this.rdoBackup);
            this.panel2.Location = new System.Drawing.Point(42, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 138);
            this.panel2.TabIndex = 481;
            // 
            // lblBrowse
            // 
            this.lblBrowse.AutoSize = true;
            this.lblBrowse.Location = new System.Drawing.Point(291, 72);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(42, 13);
            this.lblBrowse.TabIndex = 467;
            this.lblBrowse.TabStop = true;
            this.lblBrowse.Text = "Browse";
            this.lblBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBrowse_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 457;
            this.label2.Text = "Database:";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(114, 45);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(171, 20);
            this.txtPath.TabIndex = 466;
            this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 465;
            this.label5.Text = "File Location:";
            // 
            // rdoRestore
            // 
            this.rdoRestore.AutoSize = true;
            this.rdoRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRestore.Location = new System.Drawing.Point(186, 99);
            this.rdoRestore.Name = "rdoRestore";
            this.rdoRestore.Size = new System.Drawing.Size(71, 21);
            this.rdoRestore.TabIndex = 464;
            this.rdoRestore.TabStop = true;
            this.rdoRestore.Text = "Restore";
            this.rdoRestore.UseVisualStyleBackColor = true;
            // 
            // rdoBackup
            // 
            this.rdoBackup.AutoSize = true;
            this.rdoBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBackup.Location = new System.Drawing.Point(108, 99);
            this.rdoBackup.Name = "rdoBackup";
            this.rdoBackup.Size = new System.Drawing.Size(67, 21);
            this.rdoBackup.TabIndex = 463;
            this.rdoBackup.TabStop = true;
            this.rdoBackup.Text = "Backup";
            this.rdoBackup.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ucManageDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "ucManageDB";
            this.Size = new System.Drawing.Size(910, 498);
            this.Load += new System.EventHandler(this.ucManageDB_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnPoced;
        private System.Windows.Forms.Label lbllast;
        private Guna.UI2.WinForms.Guna2ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lblBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoRestore;
        private System.Windows.Forms.RadioButton rdoBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
