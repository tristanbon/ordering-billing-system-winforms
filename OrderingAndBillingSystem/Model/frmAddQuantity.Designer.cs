
namespace OrderingAndBillingSystem.Model
{
    partial class frmAddQuantity
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDec = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnInc = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblQtyHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(85, 98);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(135, 66);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtQuantity_MouseClick);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.Teal;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(177, 203);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblItem);
            this.panel1.Controls.Add(this.btnDec);
            this.panel1.Controls.Add(this.btnInc);
            this.panel1.Controls.Add(this.lblQtyHeader);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 251);
            this.panel1.TabIndex = 3;
            // 
            // btnDec
            // 
            this.btnDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDec.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDec.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.btnDec.Image = global::OrderingAndBillingSystem.Properties.Resources.circle_minus_solid;
            this.btnDec.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnDec.ImageRotate = 0F;
            this.btnDec.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDec.Location = new System.Drawing.Point(36, 110);
            this.btnDec.Name = "btnDec";
            this.btnDec.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDec.Size = new System.Drawing.Size(50, 50);
            this.btnDec.TabIndex = 514;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnInc
            // 
            this.btnInc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInc.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnInc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInc.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.btnInc.Image = global::OrderingAndBillingSystem.Properties.Resources.circle_plus_solid;
            this.btnInc.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnInc.ImageRotate = 0F;
            this.btnInc.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInc.Location = new System.Drawing.Point(226, 110);
            this.btnInc.Name = "btnInc";
            this.btnInc.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnInc.Size = new System.Drawing.Size(50, 50);
            this.btnInc.TabIndex = 513;
            this.btnInc.Click += new System.EventHandler(this.btnInc_Click);
            // 
            // lblQtyHeader
            // 
            this.lblQtyHeader.AutoSize = true;
            this.lblQtyHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblQtyHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyHeader.ForeColor = System.Drawing.Color.Black;
            this.lblQtyHeader.Location = new System.Drawing.Point(8, 10);
            this.lblQtyHeader.Name = "lblQtyHeader";
            this.lblQtyHeader.Size = new System.Drawing.Size(123, 25);
            this.lblQtyHeader.TabIndex = 471;
            this.lblQtyHeader.Text = "Add Quantity";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(8, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 470;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblItem
            // 
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Black;
            this.lblItem.Location = new System.Drawing.Point(2, 49);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(302, 25);
            this.lblItem.TabIndex = 515;
            this.lblItem.Text = "(selected item)";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(313, 259);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddQuantity";
            this.Load += new System.EventHandler(this.frmAddQuantity_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblQtyHeader;
        private Guna.UI2.WinForms.Guna2ImageButton btnInc;
        private Guna.UI2.WinForms.Guna2ImageButton btnDec;
        public System.Windows.Forms.Label lblItem;
    }
}