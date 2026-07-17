
namespace OrderingAndBillingSystem.Model
{
    partial class frmCashDrawer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashDrawer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXReading = new System.Windows.Forms.Button();
            this.btnEndDay = new System.Windows.Forms.Button();
            this.btnStartDay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartingCash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeClose = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBeginning = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnding = new System.Windows.Forms.TextBox();
            this.lstCat = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtEnding);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBeginning);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pbRemove);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDaily);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStartingCash);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimeClose);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTimeStart);
            this.panel1.Controls.Add(this.lstCat);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 350);
            this.panel1.TabIndex = 471;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 529;
            this.label3.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(136, 179);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(309, 25);
            this.txtDiscount.TabIndex = 528;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 527;
            this.label9.Text = "Start of Day";
            // 
            // pbRemove
            // 
            this.pbRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(456, 4);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(27, 23);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 464;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.FillColor = System.Drawing.Color.Teal;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(487, 55);
            this.guna2Separator1.TabIndex = 526;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnXReading);
            this.panel3.Controls.Add(this.btnEndDay);
            this.panel3.Controls.Add(this.btnStartDay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 291);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 59);
            this.panel3.TabIndex = 478;
            // 
            // btnXReading
            // 
            this.btnXReading.BackColor = System.Drawing.Color.Teal;
            this.btnXReading.ForeColor = System.Drawing.Color.White;
            this.btnXReading.Location = new System.Drawing.Point(355, 10);
            this.btnXReading.Name = "btnXReading";
            this.btnXReading.Size = new System.Drawing.Size(127, 45);
            this.btnXReading.TabIndex = 480;
            this.btnXReading.Text = "X-READING";
            this.btnXReading.UseVisualStyleBackColor = false;
            this.btnXReading.Click += new System.EventHandler(this.btnXReading_Click);
            // 
            // btnEndDay
            // 
            this.btnEndDay.Location = new System.Drawing.Point(145, 10);
            this.btnEndDay.Name = "btnEndDay";
            this.btnEndDay.Size = new System.Drawing.Size(127, 45);
            this.btnEndDay.TabIndex = 479;
            this.btnEndDay.Text = "END OF DAY";
            this.btnEndDay.UseVisualStyleBackColor = true;
            this.btnEndDay.Click += new System.EventHandler(this.btnEndDay_Click);
            // 
            // btnStartDay
            // 
            this.btnStartDay.Location = new System.Drawing.Point(12, 10);
            this.btnStartDay.Name = "btnStartDay";
            this.btnStartDay.Size = new System.Drawing.Size(127, 45);
            this.btnStartDay.TabIndex = 478;
            this.btnStartDay.Text = "START OF DAY";
            this.btnStartDay.UseVisualStyleBackColor = true;
            this.btnStartDay.Click += new System.EventHandler(this.btnStartDay_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 475;
            this.label5.Text = "Daily Sales";
            // 
            // txtDaily
            // 
            this.txtDaily.Enabled = false;
            this.txtDaily.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaily.Location = new System.Drawing.Point(136, 148);
            this.txtDaily.Name = "txtDaily";
            this.txtDaily.Size = new System.Drawing.Size(309, 25);
            this.txtDaily.TabIndex = 474;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 471;
            this.label2.Text = "Starting Cash";
            // 
            // txtStartingCash
            // 
            this.txtStartingCash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingCash.Location = new System.Drawing.Point(136, 117);
            this.txtStartingCash.Name = "txtStartingCash";
            this.txtStartingCash.Size = new System.Drawing.Size(309, 25);
            this.txtStartingCash.TabIndex = 470;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 469;
            this.label1.Text = "Time Close";
            // 
            // txtTimeClose
            // 
            this.txtTimeClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeClose.Location = new System.Drawing.Point(136, 86);
            this.txtTimeClose.Name = "txtTimeClose";
            this.txtTimeClose.Size = new System.Drawing.Size(309, 25);
            this.txtTimeClose.TabIndex = 468;
            this.txtTimeClose.Click += new System.EventHandler(this.txtTimeClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 467;
            this.label4.Text = "Time Start";
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeStart.Location = new System.Drawing.Point(136, 55);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(309, 25);
            this.txtTimeStart.TabIndex = 466;
            this.txtTimeStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimeStart_MouseClick);
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
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(29, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 531;
            this.label6.Text = "Beginning";
            // 
            // txtBeginning
            // 
            this.txtBeginning.Enabled = false;
            this.txtBeginning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeginning.Location = new System.Drawing.Point(136, 210);
            this.txtBeginning.Name = "txtBeginning";
            this.txtBeginning.Size = new System.Drawing.Size(309, 25);
            this.txtBeginning.TabIndex = 530;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 533;
            this.label7.Text = "Ending";
            // 
            // txtEnding
            // 
            this.txtEnding.Enabled = false;
            this.txtEnding.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnding.Location = new System.Drawing.Point(136, 244);
            this.txtEnding.Name = "txtEnding";
            this.txtEnding.Size = new System.Drawing.Size(309, 25);
            this.txtEnding.TabIndex = 532;
            // 
            // lstCat
            // 
            this.lstCat.BackColor = System.Drawing.Color.White;
            this.lstCat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lstCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCat.FullRowSelect = true;
            this.lstCat.HideSelection = false;
            this.lstCat.Location = new System.Drawing.Point(-33, 9);
            this.lstCat.Name = "lstCat";
            this.lstCat.Size = new System.Drawing.Size(552, 18);
            this.lstCat.TabIndex = 590;
            this.lstCat.UseCompatibleStateImageBehavior = false;
            this.lstCat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Sales";
            this.columnHeader4.Width = 150;
            // 
            // frmCashDrawer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(493, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCashDrawer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashDrawer";
            this.Load += new System.EventHandler(this.frmCashDrawer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDaily;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtStartingCash;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTimeClose;
        internal System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.Button btnXReading;
        private System.Windows.Forms.Button btnEndDay;
        private System.Windows.Forms.Button btnStartDay;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        internal System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        internal System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDiscount;
        internal System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtEnding;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBeginning;
        private System.Windows.Forms.ListView lstCat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}