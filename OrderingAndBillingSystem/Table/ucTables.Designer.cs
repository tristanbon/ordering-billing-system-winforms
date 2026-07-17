
namespace OrderingAndBillingSystem.Table
{
    partial class ucTables
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lstTable = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoOfChairs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnNew = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(721, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // lstTable
            // 
            this.lstTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lstTable.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstTable.FullRowSelect = true;
            this.lstTable.HideSelection = false;
            this.lstTable.Location = new System.Drawing.Point(1, 55);
            this.lstTable.MultiSelect = false;
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(251, 462);
            this.lstTable.TabIndex = 502;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            this.lstTable.Click += new System.EventHandler(this.lstTable_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Table Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chairs";
            this.columnHeader3.Width = 80;
            // 
            // txtTableName
            // 
            this.txtTableName.BackColor = System.Drawing.Color.White;
            this.txtTableName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtTableName.Location = new System.Drawing.Point(167, 110);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(161, 33);
            this.txtTableName.TabIndex = 506;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(164, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 509;
            this.label1.Text = "No of Chairs:";
            // 
            // txtNoOfChairs
            // 
            this.txtNoOfChairs.BackColor = System.Drawing.Color.White;
            this.txtNoOfChairs.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNoOfChairs.Location = new System.Drawing.Point(167, 198);
            this.txtNoOfChairs.Name = "txtNoOfChairs";
            this.txtNoOfChairs.Size = new System.Drawing.Size(77, 33);
            this.txtNoOfChairs.TabIndex = 508;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(162, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 507;
            this.label4.Text = "Table Name:";
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
            this.btnDelete.Location = new System.Drawing.Point(167, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(205, 58);
            this.btnDelete.TabIndex = 512;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Location = new System.Drawing.Point(167, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(205, 58);
            this.btnSave.TabIndex = 510;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.Teal;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(167, 265);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(205, 58);
            this.btnNew.TabIndex = 511;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lstTable);
            this.panel2.Location = new System.Drawing.Point(1, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 645);
            this.panel2.TabIndex = 514;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 49);
            this.panel1.TabIndex = 516;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.txtTableName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtNoOfChairs);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(248, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 612);
            this.panel3.TabIndex = 515;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(473, 49);
            this.panel5.TabIndex = 518;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.Location = new System.Drawing.Point(236, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 700);
            this.panel7.TabIndex = 517;
            // 
            // ucTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "ucTables";
            this.Size = new System.Drawing.Size(721, 571);
            this.Load += new System.EventHandler(this.ucTables_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtTableName;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoOfChairs;
        internal System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}
