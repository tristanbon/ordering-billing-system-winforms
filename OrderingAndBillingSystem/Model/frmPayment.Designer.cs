
namespace OrderingAndBillingSystem.Model
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTendered = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.RprintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btn00);
            this.panel1.Controls.Add(this.btnpoint);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.txtTendered);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 493);
            this.panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(242, 267);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 42);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 491;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(242, 318);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(118, 45);
            this.btnGenerate.TabIndex = 489;
            this.btnGenerate.Text = "Receipt";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(242, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 45);
            this.btnCancel.TabIndex = 488;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 22);
            this.label8.TabIndex = 485;
            this.label8.Text = "Amount to pay";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Teal;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(242, 369);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(118, 45);
            this.btnPay.TabIndex = 479;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btn00
            // 
            this.btn00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn00.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(167, 420);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(60, 45);
            this.btn00.TabIndex = 476;
            this.btn00.Text = "00";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpoint.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.Location = new System.Drawing.Point(92, 420);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(60, 45);
            this.btnpoint.TabIndex = 475;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = true;
            this.btnpoint.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn0
            // 
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(20, 420);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(60, 45);
            this.btn0.TabIndex = 474;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(167, 369);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 45);
            this.btn9.TabIndex = 473;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(167, 318);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 45);
            this.btn6.TabIndex = 472;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(167, 267);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 45);
            this.btn3.TabIndex = 471;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(92, 369);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 45);
            this.btn8.TabIndex = 470;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(92, 318);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 45);
            this.btn5.TabIndex = 469;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(92, 267);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 45);
            this.btn2.TabIndex = 468;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(20, 369);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 45);
            this.btn7.TabIndex = 467;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(20, 318);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 45);
            this.btn4.TabIndex = 466;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(20, 267);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 45);
            this.btn1.TabIndex = 465;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberOperator_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtDiscount.Location = new System.Drawing.Point(242, 135);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(118, 42);
            this.txtDiscount.TabIndex = 463;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter_1);
            // 
            // txtChange
            // 
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.txtChange.Location = new System.Drawing.Point(20, 209);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Multiline = true;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(340, 41);
            this.txtChange.TabIndex = 462;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 98);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(361, 10);
            this.guna2Separator1.TabIndex = 461;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.Color.White;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 41);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(340, 41);
            this.lblTotalAmount.TabIndex = 458;
            this.lblTotalAmount.Text = "0.00";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTendered
            // 
            this.txtTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTendered.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendered.Location = new System.Drawing.Point(20, 135);
            this.txtTendered.Margin = new System.Windows.Forms.Padding(4);
            this.txtTendered.Multiline = true;
            this.txtTendered.Name = "txtTendered";
            this.txtTendered.Size = new System.Drawing.Size(207, 41);
            this.txtTendered.TabIndex = 451;
            this.txtTendered.TextChanged += new System.EventHandler(this.txtTendered_TextChanged);
            this.txtTendered.Enter += new System.EventHandler(this.txtTendered_Enter_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(4, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 448;
            this.label3.Text = "Change:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(238, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 447;
            this.label2.Text = "Discount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(5, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 446;
            this.label1.Text = "Tendered:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RprintPreviewDialog
            // 
            this.RprintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.RprintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.RprintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.RprintPreviewDialog.Enabled = true;
            this.RprintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("RprintPreviewDialog.Icon")));
            this.RprintPreviewDialog.Name = "RprintPreviewDialog";
            this.RprintPreviewDialog.Visible = false;
            this.RprintPreviewDialog.Load += new System.EventHandler(this.RprintPreviewDialog_Load);
            // 
            // RprintDocument
            // 
            this.RprintDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.RprintDocument_BeginPrint);
            this.RprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.RprintDocument_PrintPage);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(396, 509);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTendered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnpoint;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.PrintPreviewDialog RprintPreviewDialog;
        public System.Drawing.Printing.PrintDocument RprintDocument;
        public System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox btnClear;
    }
}