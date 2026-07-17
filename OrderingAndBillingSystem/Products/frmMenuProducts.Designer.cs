
namespace OrderingAndBillingSystem.Products
{
    partial class frmMenuProducts
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.btnCategories = new Guna.UI2.WinForms.Guna2Button();
            this.btnManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(982, 52);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // pnlProducts
            // 
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(0, 107);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(982, 441);
            this.pnlProducts.TabIndex = 4;
            // 
            // btnCategories
            // 
            this.btnCategories.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategories.Checked = true;
            this.btnCategories.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnCategories.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnCategories.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCategories.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategories.FillColor = System.Drawing.SystemColors.Control;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.Black;
            this.btnCategories.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnCategories.Location = new System.Drawing.Point(4, 1);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(202, 51);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Manage Categories";
            this.btnCategories.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnManage
            // 
            this.btnManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManage.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManage.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnManage.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnManage.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManage.FillColor = System.Drawing.SystemColors.Control;
            this.btnManage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.Black;
            this.btnManage.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnManage.Location = new System.Drawing.Point(212, 1);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(202, 51);
            this.btnManage.TabIndex = 1;
            this.btnManage.Text = "Manage Products";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAllProducts.CheckedState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllProducts.CheckedState.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllProducts.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnAllProducts.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAllProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllProducts.FillColor = System.Drawing.SystemColors.Control;
            this.btnAllProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllProducts.ForeColor = System.Drawing.Color.Black;
            this.btnAllProducts.HoverState.CustomBorderColor = System.Drawing.Color.Teal;
            this.btnAllProducts.Location = new System.Drawing.Point(416, 1);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(202, 51);
            this.btnAllProducts.TabIndex = 3;
            this.btnAllProducts.Text = "All Products";
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnAllProducts);
            this.panel2.Controls.Add(this.btnManage);
            this.panel2.Controls.Add(this.btnCategories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 55);
            this.panel2.TabIndex = 2;
            // 
            // frmMenuProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 548);
            this.Controls.Add(this.pnlProducts);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProducts";
            this.Text = "frmMenuProducts";
            this.Load += new System.EventHandler(this.frmMenuProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProducts;
        private Guna.UI2.WinForms.Guna2Button btnCategories;
        private Guna.UI2.WinForms.Guna2Button btnManage;
        private Guna.UI2.WinForms.Guna2Button btnAllProducts;
        private System.Windows.Forms.Panel panel2;
    }
}