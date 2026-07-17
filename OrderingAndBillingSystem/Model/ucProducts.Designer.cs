
namespace OrderingAndBillingSystem.Model
{
    partial class ucProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbNotAvailable = new System.Windows.Forms.PictureBox();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pb1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 169);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 31);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Product Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.ClickEvent);
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.lblName.MouseLeave += new System.EventHandler(this.LeaveEvent);
            this.lblName.MouseHover += new System.EventHandler(this.HoverEvent);
            this.lblName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 1);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(189, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 210);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 210);
            this.panel4.TabIndex = 9;
            // 
            // pbNotAvailable
            // 
            this.pbNotAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pbNotAvailable.Image")));
            this.pbNotAvailable.Location = new System.Drawing.Point(13, 14);
            this.pbNotAvailable.Name = "pbNotAvailable";
            this.pbNotAvailable.Size = new System.Drawing.Size(165, 146);
            this.pbNotAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotAvailable.TabIndex = 430;
            this.pbNotAvailable.TabStop = false;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.BorderRadius = 10;
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(11, 11);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(167, 152);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 5;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.ClickEvent);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.pbImage.MouseLeave += new System.EventHandler(this.LeaveEvent);
            this.pbImage.MouseHover += new System.EventHandler(this.HoverEvent);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Gainsboro;
            this.pb2.BorderRadius = 10;
            this.pb2.ImageRotate = 0F;
            this.pb2.Location = new System.Drawing.Point(7, 7);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(175, 197);
            this.pb2.TabIndex = 429;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.ClickEvent);
            this.pb2.MouseLeave += new System.EventHandler(this.LeaveEvent);
            this.pb2.MouseHover += new System.EventHandler(this.HoverEvent);
            // 
            // pb1
            // 
            this.pb1.BorderRadius = 10;
            this.pb1.FillColor = System.Drawing.Color.Gainsboro;
            this.pb1.ImageRotate = 0F;
            this.pb1.Location = new System.Drawing.Point(3, 3);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(183, 205);
            this.pb1.TabIndex = 428;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.ClickEvent);
            this.pb1.MouseLeave += new System.EventHandler(this.LeaveEvent);
            this.pb1.MouseHover += new System.EventHandler(this.HoverEvent);
            // 
            // ucProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.pbNotAvailable);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(190, 212);
            this.Click += new System.EventHandler(this.ClickEvent);
            this.MouseLeave += new System.EventHandler(this.LeaveEvent);
            this.MouseHover += new System.EventHandler(this.HoverEvent);
            ((System.ComponentModel.ISupportInitialize)(this.pbNotAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2PictureBox pb1;
        private Guna.UI2.WinForms.Guna2PictureBox pb2;
        private System.Windows.Forms.PictureBox pbNotAvailable;
    }
}
