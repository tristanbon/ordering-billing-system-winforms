
namespace OrderingAndBillingSystem.Reports
{
    partial class ucBestSelling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBestSelling));
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.dtEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstSales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldtfrom = new System.Windows.Forms.Label();
            this.lbldtTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1171, 10);
            this.guna2Separator1.TabIndex = 546;
            // 
            // btnShow
            // 
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.Teal;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(562, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 30);
            this.btnShow.TabIndex = 552;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtEndDate
            // 
            this.dtEndDate.Checked = true;
            this.dtEndDate.FillColor = System.Drawing.Color.White;
            this.dtEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndDate.Location = new System.Drawing.Point(254, 57);
            this.dtEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(132, 30);
            this.dtEndDate.TabIndex = 551;
            this.dtEndDate.Value = new System.DateTime(2023, 10, 11, 9, 3, 5, 168);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 550;
            this.label9.Text = "To:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Checked = true;
            this.dtStartDate.FillColor = System.Drawing.Color.White;
            this.dtStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(72, 58);
            this.dtStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(132, 30);
            this.dtStartDate.TabIndex = 549;
            this.dtStartDate.Value = new System.DateTime(2023, 10, 11, 9, 3, 5, 168);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 548;
            this.label10.Text = "From:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(17, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1133, 27);
            this.panel3.TabIndex = 555;
            // 
            // lstSales
            // 
            this.lstSales.BackColor = System.Drawing.Color.White;
            this.lstSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstSales.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstSales.FullRowSelect = true;
            this.lstSales.HideSelection = false;
            this.lstSales.Location = new System.Drawing.Point(17, 250);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(1133, 320);
            this.lstSales.TabIndex = 554;
            this.lstSales.UseCompatibleStateImageBehavior = false;
            this.lstSales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rank";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Item Name";
            this.columnHeader3.Width = 650;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 90;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
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
            // btnGenerate
            // 
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor = System.Drawing.Color.Teal;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(757, 58);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(180, 30);
            this.btnGenerate.TabIndex = 558;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Teal;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(955, 57);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 30);
            this.btnPrint.TabIndex = 559;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 557;
            this.label1.Text = "Food Items Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 560;
            this.label2.Text = "GREEN HOUSE RESTO BAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 561;
            this.label3.Text = "GUBAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 562;
            this.label4.Text = "Date  From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 563;
            this.label5.Text = "Date  To:";
            // 
            // lbldtfrom
            // 
            this.lbldtfrom.AutoSize = true;
            this.lbldtfrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtfrom.Location = new System.Drawing.Point(120, 152);
            this.lbldtfrom.Name = "lbldtfrom";
            this.lbldtfrom.Size = new System.Drawing.Size(90, 21);
            this.lbldtfrom.TabIndex = 564;
            this.lbldtfrom.Text = "Date  From:";
            this.lbldtfrom.Visible = false;
            // 
            // lbldtTo
            // 
            this.lbldtTo.AutoSize = true;
            this.lbldtTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtTo.Location = new System.Drawing.Point(120, 173);
            this.lbldtTo.Name = "lbldtTo";
            this.lbldtTo.Size = new System.Drawing.Size(68, 21);
            this.lbldtTo.TabIndex = 565;
            this.lbldtTo.Text = "Date  To:";
            this.lbldtTo.Visible = false;
            // 
            // ucBestSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbldtTo);
            this.Controls.Add(this.lbldtfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2Separator1);
            this.Name = "ucBestSelling";
            this.Size = new System.Drawing.Size(1171, 612);
            this.Load += new System.EventHandler(this.ucBestSelling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstSales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldtfrom;
        private System.Windows.Forms.Label lbldtTo;
    }
}
