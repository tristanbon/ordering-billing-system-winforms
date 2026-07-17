
namespace OrderingAndBillingSystem.Model
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartTopProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.flpPopulalItem = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.lstSales = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrre = new Guna.UI2.WinForms.Guna2Button();
            this.btnPri = new Guna.UI2.WinForms.Guna2Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomDate.Location = new System.Drawing.Point(410, 78);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(110, 29);
            this.btnCustomDate.TabIndex = 39;
            this.btnCustomDate.Text = "Custom";
            this.btnCustomDate.UseVisualStyleBackColor = true;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnToday.Location = new System.Drawing.Point(530, 78);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(145, 29);
            this.btnToday.TabIndex = 38;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLast7Days.Location = new System.Drawing.Point(685, 78);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(138, 29);
            this.btnLast7Days.TabIndex = 37;
            this.btnLast7Days.Text = "Last 7 days";
            this.btnLast7Days.UseVisualStyleBackColor = true;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLast30Days.Location = new System.Drawing.Point(833, 78);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(135, 29);
            this.btnLast30Days.TabIndex = 36;
            this.btnLast30Days.Text = "Last 30 days";
            this.btnLast30Days.UseVisualStyleBackColor = true;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.Location = new System.Drawing.Point(978, 78);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(137, 29);
            this.btnThisMonth.TabIndex = 35;
            this.btnThisMonth.Text = "This month";
            this.btnThisMonth.UseVisualStyleBackColor = true;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(196, 76);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(142, 29);
            this.dtpEndDate.TabIndex = 34;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(54, 76);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 29);
            this.dtpStartDate.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.chartTopProducts);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.flpPopulalItem);
            this.panel4.Location = new System.Drawing.Point(649, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 371);
            this.panel4.TabIndex = 46;
            // 
            // chartTopProducts
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTopProducts.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chartTopProducts.Legends.Add(legend3);
            this.chartTopProducts.Location = new System.Drawing.Point(-10, -5);
            this.chartTopProducts.Margin = new System.Windows.Forms.Padding(5);
            this.chartTopProducts.Name = "chartTopProducts";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series3.IsValueShownAsLabel = true;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTopProducts.Series.Add(series3);
            this.chartTopProducts.Size = new System.Drawing.Size(461, 376);
            this.chartTopProducts.TabIndex = 530;
            this.chartTopProducts.Text = "chartTopProducts";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title3.Name = "Title1";
            title3.Text = "5 Best selling products";
            this.chartTopProducts.Titles.Add(title3);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(27, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Best Selling Items";
            // 
            // flpPopulalItem
            // 
            this.flpPopulalItem.Location = new System.Drawing.Point(21, 71);
            this.flpPopulalItem.Name = "flpPopulalItem";
            this.flpPopulalItem.Size = new System.Drawing.Size(346, 12);
            this.flpPopulalItem.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumOrders);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(54, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 98);
            this.panel1.TabIndex = 526;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(141)))), ((int)(((byte)(181)))));
            this.label3.Location = new System.Drawing.Point(427, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "+15%";
            // 
            // lblNumOrders
            // 
            this.lblNumOrders.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrders.ForeColor = System.Drawing.Color.White;
            this.lblNumOrders.Location = new System.Drawing.Point(12, 27);
            this.lblNumOrders.Name = "lblNumOrders";
            this.lblNumOrders.Size = new System.Drawing.Size(217, 49);
            this.lblNumOrders.TabIndex = 1;
            this.lblNumOrders.Text = "0";
            this.lblNumOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTotalRevenue);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(649, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 98);
            this.panel2.TabIndex = 527;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(18, 27);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(208, 49);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "0.0";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(14, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Sales";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblProducts);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(322, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 98);
            this.panel3.TabIndex = 528;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblProducts
            // 
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(21, 30);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(208, 49);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "0";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(14, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Products";
            // 
            // pbOk
            // 
            this.pbOk.BackColor = System.Drawing.Color.White;
            this.pbOk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOk.Image = ((System.Drawing.Image)(resources.GetObject("pbOk.Image")));
            this.pbOk.Location = new System.Drawing.Point(372, 78);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(39, 29);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOk.TabIndex = 529;
            this.pbOk.TabStop = false;
            this.pbOk.Visible = false;
            this.pbOk.Click += new System.EventHandler(this.pbOk_Click);
            // 
            // lstSales
            // 
            this.lstSales.BackColor = System.Drawing.Color.White;
            this.lstSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstSales.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lstSales.FullRowSelect = true;
            this.lstSales.HideSelection = false;
            this.lstSales.Location = new System.Drawing.Point(98, 284);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(254, 225);
            this.lstSales.TabIndex = 547;
            this.lstSales.UseCompatibleStateImageBehavior = false;
            this.lstSales.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order No";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Amount";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cash Tendered";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Change";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Discount";
            this.columnHeader7.Width = 150;
            // 
            // chartSales
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSales.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.chartSales.Legends.Add(legend4);
            this.chartSales.Location = new System.Drawing.Point(54, 248);
            this.chartSales.Margin = new System.Windows.Forms.Padding(5);
            this.chartSales.Name = "chartSales";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartSales.Series.Add(series4);
            this.chartSales.Size = new System.Drawing.Size(575, 458);
            this.chartSales.TabIndex = 548;
            this.chartSales.Text = "chartGrossRevenue";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.Name = "Title1";
            title4.Text = "Gross revenue";
            this.chartSales.Titles.Add(title4);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 33);
            this.label1.TabIndex = 549;
            this.label1.Text = "WELCOME TO GREEN HOUSE RESTO BAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // btnPrre
            // 
            this.btnPrre.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrre.FillColor = System.Drawing.Color.Teal;
            this.btnPrre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrre.ForeColor = System.Drawing.Color.White;
            this.btnPrre.Location = new System.Drawing.Point(649, 648);
            this.btnPrre.Name = "btnPrre";
            this.btnPrre.Size = new System.Drawing.Size(205, 58);
            this.btnPrre.TabIndex = 552;
            this.btnPrre.Text = "Preview";
            this.btnPrre.Click += new System.EventHandler(this.btnPrre_Click);
            // 
            // btnPri
            // 
            this.btnPri.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPri.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPri.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPri.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPri.FillColor = System.Drawing.Color.Teal;
            this.btnPri.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPri.ForeColor = System.Drawing.Color.White;
            this.btnPri.Location = new System.Drawing.Point(910, 648);
            this.btnPri.Name = "btnPri";
            this.btnPri.Size = new System.Drawing.Size(205, 58);
            this.btnPri.TabIndex = 553;
            this.btnPri.Text = "Print";
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1162, 730);
            this.Controls.Add(this.btnPri);
            this.Controls.Add(this.btnPrre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flpPopulalItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopProducts;
        private System.Windows.Forms.ListView lstSales;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private Guna.UI2.WinForms.Guna2Button btnPrre;
        private Guna.UI2.WinForms.Guna2Button btnPri;
    }
}