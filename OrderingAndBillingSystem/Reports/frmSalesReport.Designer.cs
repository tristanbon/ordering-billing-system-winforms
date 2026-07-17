
namespace OrderingAndBillingSystem.Reports
{
    partial class frmSalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXreading = new Guna.UI2.WinForms.Guna2Button();
            this.btnBestSell = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllSales = new Guna.UI2.WinForms.Guna2Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnXreading);
            this.panel2.Controls.Add(this.btnBestSell);
            this.panel2.Controls.Add(this.btnAllSales);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 55);
            this.panel2.TabIndex = 1;
            // 
            // btnXreading
            // 
            this.btnXreading.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnXreading.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnXreading.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnXreading.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnXreading.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnXreading.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXreading.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXreading.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXreading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXreading.FillColor = System.Drawing.SystemColors.Control;
            this.btnXreading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXreading.ForeColor = System.Drawing.Color.Black;
            this.btnXreading.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnXreading.Location = new System.Drawing.Point(419, 1);
            this.btnXreading.Name = "btnXreading";
            this.btnXreading.Size = new System.Drawing.Size(202, 51);
            this.btnXreading.TabIndex = 3;
            this.btnXreading.Text = "X-Reading";
            this.btnXreading.Click += new System.EventHandler(this.btnXreading_Click);
            // 
            // btnBestSell
            // 
            this.btnBestSell.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBestSell.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnBestSell.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnBestSell.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnBestSell.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnBestSell.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBestSell.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBestSell.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBestSell.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBestSell.FillColor = System.Drawing.SystemColors.Control;
            this.btnBestSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBestSell.ForeColor = System.Drawing.Color.Black;
            this.btnBestSell.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnBestSell.Location = new System.Drawing.Point(212, 1);
            this.btnBestSell.Name = "btnBestSell";
            this.btnBestSell.Size = new System.Drawing.Size(202, 51);
            this.btnBestSell.TabIndex = 2;
            this.btnBestSell.Text = "Transaction Reports";
            this.btnBestSell.Click += new System.EventHandler(this.btnBestSell_Click);
            // 
            // btnAllSales
            // 
            this.btnAllSales.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllSales.Checked = true;
            this.btnAllSales.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllSales.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllSales.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAllSales.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAllSales.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllSales.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllSales.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllSales.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllSales.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSales.ForeColor = System.Drawing.Color.Black;
            this.btnAllSales.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllSales.Location = new System.Drawing.Point(4, 1);
            this.btnAllSales.Name = "btnAllSales";
            this.btnAllSales.Size = new System.Drawing.Size(202, 51);
            this.btnAllSales.TabIndex = 0;
            this.btnAllSales.Text = "Food Items Report";
            this.btnAllSales.Click += new System.EventHandler(this.btnAllSales_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReports.Location = new System.Drawing.Point(0, 107);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(947, 404);
            this.pnlReports.TabIndex = 2;
            this.pnlReports.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReports_Paint);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 511);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAllSales;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnBestSell;
        private Guna.UI2.WinForms.Guna2Button btnXreading;
    }
}