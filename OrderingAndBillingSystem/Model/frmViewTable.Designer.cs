
namespace OrderingAndBillingSystem.Model
{
    partial class frmViewTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTable));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotif = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.Color.White;
            this.flpTable.Location = new System.Drawing.Point(12, 96);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1331, 630);
            this.flpTable.TabIndex = 422;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(38, 38);
            this.btnExit.Location = new System.Drawing.Point(24, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 513;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblNotif);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 754);
            this.panel1.TabIndex = 427;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNotif.Location = new System.Drawing.Point(506, 44);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(271, 25);
            this.lblNotif.TabIndex = 517;
            this.lblNotif.Text = "(Double Click Button To Enable)";
            this.lblNotif.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1217, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 516;
            this.label1.Text = "Next";
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(44, 44);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(38, 38);
            this.btnNext.Location = new System.Drawing.Point(1269, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 515;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 514;
            this.label5.Text = "Back";
            // 
            // frmViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1360, 770);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewTable";
            this.Text = "frmViewTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewTable_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNotif;
    }
}