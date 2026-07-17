
namespace OrderingAndBillingSystem.Reports
{
    partial class ucReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReports));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lstSales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btPreview = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1161, 10);
            this.guna2Separator1.TabIndex = 545;
            // 
            // lstSales
            // 
            this.lstSales.BackColor = System.Drawing.Color.White;
            this.lstSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader7});
            this.lstSales.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstSales.FullRowSelect = true;
            this.lstSales.HideSelection = false;
            this.lstSales.Location = new System.Drawing.Point(33, 98);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(1086, 448);
            this.lstSales.TabIndex = 546;
            this.lstSales.UseCompatibleStateImageBehavior = false;
            this.lstSales.View = System.Windows.Forms.View.Details;
            this.lstSales.Click += new System.EventHandler(this.lstSales_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order No";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Amount";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Discount";
            this.columnHeader7.Width = 150;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            this.printPreviewDialog.Load += new System.EventHandler(this.printPreviewDialog_Load);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(33, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 27);
            this.panel3.TabIndex = 549;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 522;
            this.label2.Text = "ORDER DETAILS";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly ",
            "Yearly"});
            this.cmbFilter.Location = new System.Drawing.Point(33, 32);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(193, 33);
            this.cmbFilter.TabIndex = 550;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btPreview
            // 
            this.btPreview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPreview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPreview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPreview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPreview.FillColor = System.Drawing.Color.Teal;
            this.btPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPreview.ForeColor = System.Drawing.Color.White;
            this.btPreview.Location = new System.Drawing.Point(752, 32);
            this.btPreview.Name = "btPreview";
            this.btPreview.Size = new System.Drawing.Size(174, 33);
            this.btPreview.TabIndex = 553;
            this.btPreview.Text = "Generate";
            this.btPreview.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Teal;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(942, 32);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(174, 33);
            this.guna2Button2.TabIndex = 555;
            this.guna2Button2.Text = "Print";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btPreview);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.guna2Separator1);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1161, 604);
            this.Load += new System.EventHandler(this.ucReports_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.ListView lstSales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Guna.UI2.WinForms.Guna2Button btPreview;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
