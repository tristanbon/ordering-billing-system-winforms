namespace OrderingAndBillingSystem.View
{
    partial class ucOrderItem
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
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblItemQty = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblItemSubTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOrderItem = new System.Windows.Forms.Panel();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.pnlOrderItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemPrice.Location = new System.Drawing.Point(469, 3);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(122, 41);
            this.lblItemPrice.TabIndex = 23;
            this.lblItemPrice.Text = "₱ 100.00";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemPrice.Click += new System.EventHandler(this.pnlItem_Click);
            this.lblItemPrice.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.lblItemPrice.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemName.Location = new System.Drawing.Point(0, 3);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(357, 35);
            this.lblItemName.TabIndex = 21;
            this.lblItemName.Text = "TapSilog";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemName.Click += new System.EventHandler(this.pnlItem_Click);
            this.lblItemName.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.lblItemName.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Location = new System.Drawing.Point(731, 15);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 20);
            this.panel10.TabIndex = 20;
            this.panel10.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.panel10.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightGray;
            this.panel13.Location = new System.Drawing.Point(462, 17);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 20);
            this.panel13.TabIndex = 19;
            this.panel13.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.panel13.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // lblItemQty
            // 
            this.lblItemQty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemQty.Location = new System.Drawing.Point(379, 3);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(81, 41);
            this.lblItemQty.TabIndex = 17;
            this.lblItemQty.Text = "1";
            this.lblItemQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemQty.Click += new System.EventHandler(this.pnlItem_Click);
            this.lblItemQty.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.lblItemQty.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.LightGray;
            this.panel14.Location = new System.Drawing.Point(372, 15);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1, 20);
            this.panel14.TabIndex = 18;
            this.panel14.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.panel14.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // lblItemSubTotal
            // 
            this.lblItemSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemSubTotal.Location = new System.Drawing.Point(604, 3);
            this.lblItemSubTotal.Name = "lblItemSubTotal";
            this.lblItemSubTotal.Size = new System.Drawing.Size(121, 41);
            this.lblItemSubTotal.TabIndex = 26;
            this.lblItemSubTotal.Text = "₱ 100.00";
            this.lblItemSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblItemSubTotal.Click += new System.EventHandler(this.pnlItem_Click);
            this.lblItemSubTotal.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.lblItemSubTotal.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(597, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 20);
            this.panel1.TabIndex = 25;
            this.panel1.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.OrderMouseHover);
            // 
            // pnlOrderItem
            // 
            this.pnlOrderItem.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderItem.Controls.Add(this.pnlItem);
            this.pnlOrderItem.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderItem.Name = "pnlOrderItem";
            this.pnlOrderItem.Size = new System.Drawing.Size(892, 47);
            this.pnlOrderItem.TabIndex = 27;
            this.pnlOrderItem.Click += new System.EventHandler(this.pnlItem_Click);
            // 
            // pnlItem
            // 
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItem.Location = new System.Drawing.Point(0, 0);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(892, 47);
            this.pnlItem.TabIndex = 28;
            this.pnlItem.Click += new System.EventHandler(this.pnlItem_Click);
            // 
            // ucOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.lblItemSubTotal);
            this.Controls.Add(this.lblItemPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemQty);
            this.Controls.Add(this.pnlOrderItem);
            this.Name = "ucOrderItem";
            this.Size = new System.Drawing.Size(892, 47);
            this.Click += new System.EventHandler(this.pnlItem_Click);
            this.MouseLeave += new System.EventHandler(this.OrderMouseLeave);
            this.MouseHover += new System.EventHandler(this.OrderMouseHover);
            this.pnlOrderItem.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblItemQty;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lblItemSubTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOrderItem;
        private System.Windows.Forms.Panel pnlItem;
    }
}
