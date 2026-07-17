
namespace OrderingAndBillingSystem.Model
{
    partial class frmBillList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillList));
            this.panel7 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBillList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnManageOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnKOT = new System.Windows.Forms.Button();
            this.btnPayOrder = new System.Windows.Forms.Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.KotprintDocument = new System.Drawing.Printing.PrintDocument();
            this.KotprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 143);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1381, 37);
            this.panel7.TabIndex = 444;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1027, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 18);
            this.label19.TabIndex = 70;
            this.label19.Text = "Discount";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(387, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 18);
            this.label18.TabIndex = 69;
            this.label18.Text = "Status";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(85, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 18);
            this.label16.TabIndex = 67;
            this.label16.Text = "Table";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(701, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 66;
            this.label11.Text = "Total Price";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(903, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Change";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(801, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Tendered";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(594, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Total Qty";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(432, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Order Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Order No.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pnlBillList);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 757);
            this.panel2.TabIndex = 447;
            // 
            // pnlBillList
            // 
            this.pnlBillList.AutoScroll = true;
            this.pnlBillList.BackColor = System.Drawing.Color.White;
            this.pnlBillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBillList.Location = new System.Drawing.Point(0, 180);
            this.pnlBillList.Name = "pnlBillList";
            this.pnlBillList.Size = new System.Drawing.Size(1381, 577);
            this.pnlBillList.TabIndex = 445;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnManageOrder);
            this.panel1.Controls.Add(this.btnPaid);
            this.panel1.Controls.Add(this.btnPending);
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnKOT);
            this.panel1.Controls.Add(this.btnPayOrder);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 143);
            this.panel1.TabIndex = 446;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.btnExit.Image = global::OrderingAndBillingSystem.Properties.Resources.circle_arrow_left_solid;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(38, 38);
            this.btnExit.Location = new System.Drawing.Point(27, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 533;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageOrder.FillColor = System.Drawing.Color.Teal;
            this.btnManageOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.ForeColor = System.Drawing.Color.White;
            this.btnManageOrder.Location = new System.Drawing.Point(704, 21);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(191, 55);
            this.btnManageOrder.TabIndex = 532;
            this.btnManageOrder.Text = "Manage Order";
            this.btnManageOrder.Visible = false;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.BackColor = System.Drawing.Color.White;
            this.btnPaid.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.Black;
            this.btnPaid.Location = new System.Drawing.Point(262, 75);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(95, 47);
            this.btnPaid.TabIndex = 530;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // btnPending
            // 
            this.btnPending.BackColor = System.Drawing.Color.White;
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.ForeColor = System.Drawing.Color.Black;
            this.btnPending.Location = new System.Drawing.Point(362, 75);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(125, 47);
            this.btnPending.TabIndex = 529;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = false;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.White;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(188, 75);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(68, 47);
            this.btnAll.TabIndex = 528;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnKOT
            // 
            this.btnKOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKOT.BackColor = System.Drawing.Color.White;
            this.btnKOT.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnKOT.ForeColor = System.Drawing.Color.Black;
            this.btnKOT.Location = new System.Drawing.Point(906, 21);
            this.btnKOT.Name = "btnKOT";
            this.btnKOT.Size = new System.Drawing.Size(186, 43);
            this.btnKOT.TabIndex = 527;
            this.btnKOT.Text = "Order Tickets";
            this.btnKOT.UseVisualStyleBackColor = false;
            this.btnKOT.Visible = false;
            this.btnKOT.Click += new System.EventHandler(this.btnKOT_Click);
            // 
            // btnPayOrder
            // 
            this.btnPayOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayOrder.BackColor = System.Drawing.Color.Teal;
            this.btnPayOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnPayOrder.ForeColor = System.Drawing.Color.White;
            this.btnPayOrder.Location = new System.Drawing.Point(1134, 26);
            this.btnPayOrder.Name = "btnPayOrder";
            this.btnPayOrder.Size = new System.Drawing.Size(174, 43);
            this.btnPayOrder.TabIndex = 525;
            this.btnPayOrder.Text = "Pay Order";
            this.btnPayOrder.UseVisualStyleBackColor = false;
            this.btnPayOrder.Click += new System.EventHandler(this.btnPayOrder_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(135, 48);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(23, 74);
            this.guna2VSeparator1.TabIndex = 509;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(73, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 20);
            this.label10.TabIndex = 508;
            this.label10.Text = "Back";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(187, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 30);
            this.label9.TabIndex = 505;
            this.label9.Text = "Sales History";
            // 
            // KotprintDocument
            // 
            this.KotprintDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.KotprintDocument_BeginPrint);
            this.KotprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.KotprintDocument_PrintPage);
            // 
            // KotprintPreviewDialog
            // 
            this.KotprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.KotprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.KotprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.KotprintPreviewDialog.Enabled = true;
            this.KotprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("KotprintPreviewDialog.Icon")));
            this.KotprintPreviewDialog.Name = "KotprintPreviewDialog";
            this.KotprintPreviewDialog.Visible = false;
            // 
            // frmBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1340, 763);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmBillList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBillList_Load);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnlBillList;
        private System.Drawing.Printing.PrintDocument KotprintDocument;
        private System.Windows.Forms.PrintPreviewDialog KotprintPreviewDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKOT;
        private System.Windows.Forms.Button btnPayOrder;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnAll;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2Button btnManageOrder;
    }
}