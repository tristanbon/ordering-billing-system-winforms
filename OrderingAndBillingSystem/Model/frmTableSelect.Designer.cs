
namespace OrderingAndBillingSystem.Model
{
    partial class frmTableSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableSelect));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbRemove = new System.Windows.Forms.PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCurrCat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpWaiter = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.lblNotif = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pbRemove);
            this.panel2.Controls.Add(this.guna2Separator1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 45);
            this.panel2.TabIndex = 420;
            // 
            // pbRemove
            // 
            this.pbRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRemove.Image = ((System.Drawing.Image)(resources.GetObject("pbRemove.Image")));
            this.pbRemove.Location = new System.Drawing.Point(522, 0);
            this.pbRemove.Name = "pbRemove";
            this.pbRemove.Size = new System.Drawing.Size(27, 20);
            this.pbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemove.TabIndex = 463;
            this.pbRemove.TabStop = false;
            this.pbRemove.Click += new System.EventHandler(this.pbRemove_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(-2, 26);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(548, 10);
            this.guna2Separator1.TabIndex = 462;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblNotif);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblCurrCat);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.flpWaiter);
            this.panel3.Controls.Add(this.flpTable);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 445);
            this.panel3.TabIndex = 423;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 402;
            this.label1.Text = "Choose Waiter";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(323, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 32);
            this.panel5.TabIndex = 465;
            // 
            // lblCurrCat
            // 
            this.lblCurrCat.AutoSize = true;
            this.lblCurrCat.BackColor = System.Drawing.Color.Teal;
            this.lblCurrCat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrCat.ForeColor = System.Drawing.Color.White;
            this.lblCurrCat.Location = new System.Drawing.Point(88, 49);
            this.lblCurrCat.Name = "lblCurrCat";
            this.lblCurrCat.Size = new System.Drawing.Size(124, 25);
            this.lblCurrCat.TabIndex = 401;
            this.lblCurrCat.Text = "Choose Table";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(10, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 32);
            this.panel4.TabIndex = 464;
            // 
            // flpWaiter
            // 
            this.flpWaiter.AutoScroll = true;
            this.flpWaiter.BackColor = System.Drawing.Color.White;
            this.flpWaiter.Location = new System.Drawing.Point(341, 101);
            this.flpWaiter.Name = "flpWaiter";
            this.flpWaiter.Size = new System.Drawing.Size(197, 283);
            this.flpWaiter.TabIndex = 422;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(10, 101);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(307, 283);
            this.flpTable.TabIndex = 421;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnNewItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 55);
            this.panel1.TabIndex = 422;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(423, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 424;
            this.button1.Text = "&Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewItem.BackColor = System.Drawing.Color.Teal;
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.ForeColor = System.Drawing.Color.White;
            this.btnNewItem.Location = new System.Drawing.Point(297, 8);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(120, 37);
            this.btnNewItem.TabIndex = 423;
            this.btnNewItem.Text = "&Cancel";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNotif.Location = new System.Drawing.Point(59, 81);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(183, 17);
            this.lblNotif.TabIndex = 467;
            this.lblNotif.Text = "(Double Click Button To Enable)";
            this.lblNotif.Visible = false;
            // 
            // frmTableSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(553, 449);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmTableSelect_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRemove)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.PictureBox pbRemove;
        private System.Windows.Forms.FlowLayoutPanel flpWaiter;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label lblCurrCat;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblNotif;
    }
}