
namespace OrderingAndBillingSystem.Model
{
    partial class ucPopularItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPopularItem));
            this.lblRank = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblItemTotalOrders = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(11, 14);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(37, 30);
            this.lblRank.TabIndex = 11;
            this.lblRank.Text = "00";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(135, 6);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(121, 21);
            this.lblItemName.TabIndex = 10;
            this.lblItemName.Text = "Chicken Burger";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 55);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(346, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(58, 1);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(58, 54);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // lblItemTotalOrders
            // 
            this.lblItemTotalOrders.AutoSize = true;
            this.lblItemTotalOrders.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemTotalOrders.ForeColor = System.Drawing.Color.Teal;
            this.lblItemTotalOrders.Location = new System.Drawing.Point(200, 33);
            this.lblItemTotalOrders.Name = "lblItemTotalOrders";
            this.lblItemTotalOrders.Size = new System.Drawing.Size(17, 20);
            this.lblItemTotalOrders.TabIndex = 13;
            this.lblItemTotalOrders.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Orders:";
            // 
            // ucPopularItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblItemTotalOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pbImage);
            this.Name = "ucPopularItem";
            this.Size = new System.Drawing.Size(346, 65);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblItemName;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblItemTotalOrders;
        private System.Windows.Forms.Label label3;
    }
}
