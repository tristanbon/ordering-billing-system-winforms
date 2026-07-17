
namespace OrderingAndBillingSystem.Model
{
    partial class ucItemOrderList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucItemOrderList));
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lblqty = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(3, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(236, 39);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Longganisa Sealog";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(197, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(92, 26);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "₱200.00";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(14, 33);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "₱100";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 56);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(339, 10);
            this.guna2Separator1.TabIndex = 19;
            // 
            // lblqty
            // 
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(99, 34);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(60, 18);
            this.lblqty.TabIndex = 25;
            this.lblqty.Text = "1x";
            this.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Image = global::OrderingAndBillingSystem.Properties.Resources.pen_to_square_regular;
            this.btnUpdate.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUpdate.ImageRotate = 0F;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 23);
            this.btnUpdate.Location = new System.Drawing.Point(281, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.btnUpdate.Size = new System.Drawing.Size(40, 28);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemove.Image = global::OrderingAndBillingSystem.Properties.Resources.trash_can_regular;
            this.btnRemove.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRemove.ImageRotate = 0F;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Location = new System.Drawing.Point(281, 31);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.btnRemove.Size = new System.Drawing.Size(40, 28);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // pbRemove
            // 
            this.pbRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(231, 3);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(27, 20);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 18;
            this.pbRemove.TabStop = false;
            this.pbRemove.Visible = false;
            this.pbRemove.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // ucItemOrderList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pbRemove);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.Name = "ucItemOrderList";
            this.Size = new System.Drawing.Size(339, 66);
            this.Load += new System.EventHandler(this.ucItemOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pbRemove;
        public System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lblqty;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemove;
        private Guna.UI2.WinForms.Guna2ImageButton btnUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
