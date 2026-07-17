
namespace OrderingAndBillingSystem.Model
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.pnlCategoryList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProductList = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlCat = new System.Windows.Forms.Panel();
            this.btnCloseTab = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblSelectedCategory = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbCatPanel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnTable = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnCashDrawer = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDineIn = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBill = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNew = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnTakeOut = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.RprintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.RprintDocument = new System.Drawing.Printing.PrintDocument();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCatPanel)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategoryList
            // 
            this.pnlCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCategoryList.AutoScroll = true;
            this.pnlCategoryList.BackColor = System.Drawing.Color.White;
            this.pnlCategoryList.Location = new System.Drawing.Point(17, 77);
            this.pnlCategoryList.Name = "pnlCategoryList";
            this.pnlCategoryList.Size = new System.Drawing.Size(175, 501);
            this.pnlCategoryList.TabIndex = 419;
            // 
            // pnlProductList
            // 
            this.pnlProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductList.AutoScroll = true;
            this.pnlProductList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlProductList.Location = new System.Drawing.Point(219, 77);
            this.pnlProductList.Name = "pnlProductList";
            this.pnlProductList.Size = new System.Drawing.Size(832, 501);
            this.pnlProductList.TabIndex = 420;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.AutoScroll = true;
            this.pnlOrderList.BackColor = System.Drawing.Color.White;
            this.pnlOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderList.Location = new System.Drawing.Point(0, 145);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(317, 414);
            this.pnlOrderList.TabIndex = 441;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.lblTable);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.lblWaiter);
            this.panel3.Controls.Add(this.lblOrderType);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblOrderNumber);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 145);
            this.panel3.TabIndex = 452;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(18, 88);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 13);
            this.lblDate.TabIndex = 490;
            this.lblDate.Text = "01-01-10";
            this.lblDate.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(204, 46);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(89, 17);
            this.lblTable.TabIndex = 450;
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(15, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 488;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblWaiter
            // 
            this.lblWaiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiter.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(204, 69);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(94, 17);
            this.lblWaiter.TabIndex = 451;
            this.lblWaiter.Text = "Waiter:";
            this.lblWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWaiter.Visible = false;
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.ForeColor = System.Drawing.Color.White;
            this.lblOrderType.Location = new System.Drawing.Point(18, 70);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(31, 15);
            this.lblOrderType.TabIndex = 489;
            this.lblOrderType.Text = "Type";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 451;
            this.label1.Text = "Order no:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.ForeColor = System.Drawing.Color.White;
            this.lblOrderNumber.Location = new System.Drawing.Point(224, 93);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(86, 47);
            this.lblOrderNumber.TabIndex = 438;
            this.lblOrderNumber.Text = "000";
            this.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(7, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1374, 804);
            this.panel4.TabIndex = 452;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFind);
            this.panel8.Controls.Add(this.pnlCat);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 148);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1047, 65);
            this.panel8.TabIndex = 454;
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFind.IconRight = ((System.Drawing.Image)(resources.GetObject("txtFind.IconRight")));
            this.txtFind.Location = new System.Drawing.Point(808, 25);
            this.txtFind.Name = "txtFind";
            this.txtFind.PasswordChar = '\0';
            this.txtFind.PlaceholderText = "Search item";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(210, 26);
            this.txtFind.TabIndex = 456;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // pnlCat
            // 
            this.pnlCat.Controls.Add(this.btnCloseTab);
            this.pnlCat.Controls.Add(this.lblSelectedCategory);
            this.pnlCat.Controls.Add(this.guna2PictureBox1);
            this.pnlCat.Controls.Add(this.pbCatPanel);
            this.pnlCat.Location = new System.Drawing.Point(208, 9);
            this.pnlCat.Name = "pnlCat";
            this.pnlCat.Size = new System.Drawing.Size(247, 66);
            this.pnlCat.TabIndex = 454;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseTab.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnCloseTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseTab.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btnCloseTab.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseTab.Image")));
            this.btnCloseTab.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnCloseTab.ImageRotate = 0F;
            this.btnCloseTab.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCloseTab.Location = new System.Drawing.Point(195, 17);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCloseTab.Size = new System.Drawing.Size(30, 30);
            this.btnCloseTab.TabIndex = 513;
            this.btnCloseTab.Visible = false;
            this.btnCloseTab.Click += new System.EventHandler(this.ClearCategory);
            // 
            // lblSelectedCategory
            // 
            this.lblSelectedCategory.AutoSize = true;
            this.lblSelectedCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectedCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedCategory.ForeColor = System.Drawing.Color.Teal;
            this.lblSelectedCategory.Location = new System.Drawing.Point(20, 17);
            this.lblSelectedCategory.Name = "lblSelectedCategory";
            this.lblSelectedCategory.Size = new System.Drawing.Size(88, 25);
            this.lblSelectedCategory.TabIndex = 454;
            this.lblSelectedCategory.Text = "All Items";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(6, 30);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 33);
            this.guna2PictureBox1.TabIndex = 455;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbCatPanel
            // 
            this.pbCatPanel.BorderRadius = 10;
            this.pbCatPanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pbCatPanel.ImageRotate = 0F;
            this.pbCatPanel.Location = new System.Drawing.Point(4, 4);
            this.pbCatPanel.Name = "pbCatPanel";
            this.pbCatPanel.Size = new System.Drawing.Size(230, 58);
            this.pbCatPanel.TabIndex = 454;
            this.pbCatPanel.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Controls.Add(this.guna2VSeparator1);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.pnlProductList);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 148);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1047, 656);
            this.panel10.TabIndex = 456;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2VSeparator1.BackColor = System.Drawing.Color.White;
            this.guna2VSeparator1.Location = new System.Drawing.Point(195, -21);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(14, 677);
            this.guna2VSeparator1.TabIndex = 422;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.pnlCategoryList);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(213, 656);
            this.panel11.TabIndex = 421;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnTable);
            this.panel5.Controls.Add(this.btnExit);
            this.panel5.Controls.Add(this.btnCashDrawer);
            this.panel5.Controls.Add(this.guna2VSeparator2);
            this.panel5.Controls.Add(this.guna2Separator3);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnDineIn);
            this.panel5.Controls.Add(this.btnBill);
            this.panel5.Controls.Add(this.btnNew);
            this.panel5.Controls.Add(this.btnTakeOut);
            this.panel5.Controls.Add(this.btnDelivery);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1047, 148);
            this.panel5.TabIndex = 452;
            // 
            // btnTable
            // 
            this.btnTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTable.BackColor = System.Drawing.Color.White;
            this.btnTable.BorderRadius = 10;
            this.btnTable.BorderThickness = 1;
            this.btnTable.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.White;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTable.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTable.Image = ((System.Drawing.Image)(resources.GetObject("btnTable.Image")));
            this.btnTable.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTable.Location = new System.Drawing.Point(881, 30);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(98, 98);
            this.btnTable.TabIndex = 513;
            this.btnTable.Text = "TABLE";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
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
            this.btnExit.Location = new System.Drawing.Point(29, 40);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 512;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCashDrawer
            // 
            this.btnCashDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCashDrawer.BackColor = System.Drawing.Color.White;
            this.btnCashDrawer.BorderRadius = 10;
            this.btnCashDrawer.BorderThickness = 1;
            this.btnCashDrawer.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnCashDrawer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCashDrawer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCashDrawer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCashDrawer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCashDrawer.FillColor = System.Drawing.Color.White;
            this.btnCashDrawer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCashDrawer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCashDrawer.Image = ((System.Drawing.Image)(resources.GetObject("btnCashDrawer.Image")));
            this.btnCashDrawer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCashDrawer.Location = new System.Drawing.Point(260, 30);
            this.btnCashDrawer.Name = "btnCashDrawer";
            this.btnCashDrawer.Size = new System.Drawing.Size(98, 98);
            this.btnCashDrawer.TabIndex = 511;
            this.btnCashDrawer.Text = "DRAWER";
            this.btnCashDrawer.Click += new System.EventHandler(this.btnCashDrawer_Click);
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(169, 18);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(23, 112);
            this.guna2VSeparator2.TabIndex = 510;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.Location = new System.Drawing.Point(12, 135);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1025, 10);
            this.guna2Separator3.TabIndex = 446;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 451;
            this.label5.Text = "Exit";
            // 
            // btnDineIn
            // 
            this.btnDineIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDineIn.BackColor = System.Drawing.Color.White;
            this.btnDineIn.BorderRadius = 10;
            this.btnDineIn.BorderThickness = 1;
            this.btnDineIn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDineIn.CheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDineIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDineIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDineIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDineIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDineIn.FillColor = System.Drawing.Color.White;
            this.btnDineIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDineIn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDineIn.Image = ((System.Drawing.Image)(resources.GetObject("btnDineIn.Image")));
            this.btnDineIn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDineIn.Location = new System.Drawing.Point(777, 30);
            this.btnDineIn.Name = "btnDineIn";
            this.btnDineIn.Size = new System.Drawing.Size(98, 98);
            this.btnDineIn.TabIndex = 432;
            this.btnDineIn.Text = "DINE IN";
            this.btnDineIn.Click += new System.EventHandler(this.btnDineIn_Click);
            // 
            // btnBill
            // 
            this.btnBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBill.BackColor = System.Drawing.Color.White;
            this.btnBill.BorderRadius = 10;
            this.btnBill.BorderThickness = 1;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.White;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBill.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBill.Location = new System.Drawing.Point(364, 30);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(98, 98);
            this.btnBill.TabIndex = 428;
            this.btnBill.Text = "DAILY SALES";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.BorderRadius = 10;
            this.btnNew.BorderThickness = 1;
            this.btnNew.CheckedState.FillColor = System.Drawing.Color.Green;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNew.Location = new System.Drawing.Point(468, 30);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 98);
            this.btnNew.TabIndex = 426;
            this.btnNew.Text = "NEW";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnTakeOut
            // 
            this.btnTakeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTakeOut.BackColor = System.Drawing.Color.White;
            this.btnTakeOut.BorderRadius = 10;
            this.btnTakeOut.BorderThickness = 1;
            this.btnTakeOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTakeOut.CheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTakeOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeOut.FillColor = System.Drawing.Color.White;
            this.btnTakeOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTakeOut.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTakeOut.Image = ((System.Drawing.Image)(resources.GetObject("btnTakeOut.Image")));
            this.btnTakeOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTakeOut.Location = new System.Drawing.Point(673, 30);
            this.btnTakeOut.Name = "btnTakeOut";
            this.btnTakeOut.Size = new System.Drawing.Size(98, 98);
            this.btnTakeOut.TabIndex = 431;
            this.btnTakeOut.Text = "TAKE OUT";
            this.btnTakeOut.Click += new System.EventHandler(this.btnTakeOut_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelivery.BackColor = System.Drawing.Color.White;
            this.btnDelivery.BorderRadius = 10;
            this.btnDelivery.BorderThickness = 1;
            this.btnDelivery.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDelivery.CheckedState.FillColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.White;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelivery.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelivery.Location = new System.Drawing.Point(569, 30);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(98, 98);
            this.btnDelivery.TabIndex = 430;
            this.btnDelivery.Text = "DELIVERY";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Teal;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1047, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 804);
            this.panel9.TabIndex = 455;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlOrderList);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1057, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 804);
            this.panel1.TabIndex = 453;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.guna2Separator2);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lblTotalQty);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lblTotal);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 559);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 104);
            this.panel7.TabIndex = 447;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(7, 94);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(303, 10);
            this.guna2Separator2.TabIndex = 452;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qty";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalQty.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQty.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.ForeColor = System.Drawing.Color.Black;
            this.lblTotalQty.Location = new System.Drawing.Point(107, 7);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(203, 47);
            this.lblTotalQty.TabIndex = 7;
            this.lblTotalQty.Text = "0";
            this.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(106, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(203, 47);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.btnCheckOut);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 663);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 141);
            this.panel6.TabIndex = 446;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Teal;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(36, 17);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(256, 50);
            this.btnCheckOut.TabIndex = 447;
            this.btnCheckOut.Text = "PLACE ORDER";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click_1);
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
            // 
            // RprintDocument
            // 
            this.RprintDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.RprintDocument_BeginPrint);
            this.RprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.RprintDocument_PrintPage);
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlCat.ResumeLayout(false);
            this.pnlCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCatPanel)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel pnlCategoryList;
        private System.Windows.Forms.FlowLayoutPanel pnlOrderList;
        public System.Windows.Forms.Label lblTable;
        public System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private System.Windows.Forms.Label lblSelectedCategory;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2PictureBox pbCatPanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pnlCat;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        internal System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTotalQty;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.FlowLayoutPanel pnlProductList;
        public Guna.UI2.WinForms.Guna2TileButton btnCashDrawer;
        public Guna.UI2.WinForms.Guna2TileButton btnDineIn;
        public Guna.UI2.WinForms.Guna2TileButton btnBill;
        public Guna.UI2.WinForms.Guna2TileButton btnNew;
        public Guna.UI2.WinForms.Guna2TileButton btnTakeOut;
        public Guna.UI2.WinForms.Guna2TileButton btnDelivery;
        private Guna.UI2.WinForms.Guna2ImageButton btnCloseTab;
        public System.Windows.Forms.PrintPreviewDialog RprintPreviewDialog;
        public System.Drawing.Printing.PrintDocument RprintDocument;
        public Guna.UI2.WinForms.Guna2TileButton btnTable;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
    }
}