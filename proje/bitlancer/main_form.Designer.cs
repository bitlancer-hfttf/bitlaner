﻿namespace bitlancer
{
    partial class main_form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainItemsDataGrid = new System.Windows.Forms.DataGridView();
            this.butButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sellButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.adminButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.userInfoButton = new System.Windows.Forms.Button();
            this.graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.urunlerDatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bakiyeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transferlerDatgrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lastOrdersDatagrid = new System.Windows.Forms.DataGridView();
            this.kullancıAdLabel = new System.Windows.Forms.Label();
            this.kullaniciTipiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainItemsDataGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDatagrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferlerDatgrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastOrdersDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainItemsDataGrid
            // 
            this.mainItemsDataGrid.AllowUserToAddRows = false;
            this.mainItemsDataGrid.AllowUserToDeleteRows = false;
            this.mainItemsDataGrid.AllowUserToOrderColumns = true;
            this.mainItemsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainItemsDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.mainItemsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainItemsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.butButton,
            this.sellButton});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainItemsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainItemsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainItemsDataGrid.GridColor = System.Drawing.Color.Plum;
            this.mainItemsDataGrid.Location = new System.Drawing.Point(12, 35);
            this.mainItemsDataGrid.MultiSelect = false;
            this.mainItemsDataGrid.Name = "mainItemsDataGrid";
            this.mainItemsDataGrid.ReadOnly = true;
            this.mainItemsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainItemsDataGrid.ShowEditingIcon = false;
            this.mainItemsDataGrid.Size = new System.Drawing.Size(921, 383);
            this.mainItemsDataGrid.TabIndex = 0;
            this.mainItemsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainItemsDataGrid_CellContentClick);
            // 
            // butButton
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            this.butButton.DefaultCellStyle = dataGridViewCellStyle1;
            this.butButton.FillWeight = 98.47717F;
            this.butButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butButton.HeaderText = "AL";
            this.butButton.Name = "butButton";
            this.butButton.ReadOnly = true;
            this.butButton.Text = "AL";
            this.butButton.UseColumnTextForButtonValue = true;
            // 
            // sellButton
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.sellButton.DefaultCellStyle = dataGridViewCellStyle2;
            this.sellButton.FillWeight = 101.5229F;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.HeaderText = "SAT";
            this.sellButton.Name = "sellButton";
            this.sellButton.ReadOnly = true;
            this.sellButton.Text = "SAT";
            this.sellButton.UseColumnTextForButtonValue = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 424);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 317);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.adminButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.addItemButton);
            this.tabPage1.Controls.Add(this.userInfoButton);
            this.tabPage1.Controls.Add(this.graphic);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.urunlerDatagrid);
            this.tabPage1.Controls.Add(this.bakiyeLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesap Özeti:";
            // 
            // adminButton
            // 
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.Blue;
            this.adminButton.Location = new System.Drawing.Point(279, 6);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(83, 83);
            this.adminButton.TabIndex = 12;
            this.adminButton.Text = "Admin Panel";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "(Yapılan Alıma ve Belirlediğiniz Satışa Göre)";
            // 
            // addItemButton
            // 
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.addItemButton.Location = new System.Drawing.Point(368, 6);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(83, 83);
            this.addItemButton.TabIndex = 10;
            this.addItemButton.Text = "Bakiye Yükle";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // userInfoButton
            // 
            this.userInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInfoButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.userInfoButton.Location = new System.Drawing.Point(457, 6);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(83, 83);
            this.userInfoButton.TabIndex = 9;
            this.userInfoButton.Text = "Hesap Bilgileri";
            this.userInfoButton.UseVisualStyleBackColor = true;
            this.userInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // graphic
            // 
            this.graphic.BorderlineColor = System.Drawing.Color.Indigo;
            this.graphic.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graphic.Legends.Add(legend1);
            this.graphic.Location = new System.Drawing.Point(546, 6);
            this.graphic.Name = "graphic";
            this.graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.Legend = "Legend1";
            series1.Name = "Para";
            this.graphic.Series.Add(series1);
            this.graphic.Size = new System.Drawing.Size(365, 279);
            this.graphic.TabIndex = 8;
            this.graphic.Text = "chart1";
            title1.Name = "miktar";
            this.graphic.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mevcut Ürünler:";
            // 
            // urunlerDatagrid
            // 
            this.urunlerDatagrid.AllowDrop = true;
            this.urunlerDatagrid.AllowUserToAddRows = false;
            this.urunlerDatagrid.AllowUserToDeleteRows = false;
            this.urunlerDatagrid.AllowUserToOrderColumns = true;
            this.urunlerDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlerDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.urunlerDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.urunlerDatagrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.urunlerDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.urunlerDatagrid.GridColor = System.Drawing.Color.Plum;
            this.urunlerDatagrid.Location = new System.Drawing.Point(6, 92);
            this.urunlerDatagrid.MultiSelect = false;
            this.urunlerDatagrid.Name = "urunlerDatagrid";
            this.urunlerDatagrid.ReadOnly = true;
            this.urunlerDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.urunlerDatagrid.ShowEditingIcon = false;
            this.urunlerDatagrid.Size = new System.Drawing.Size(534, 193);
            this.urunlerDatagrid.TabIndex = 6;
            this.urunlerDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDatagrid_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "SAT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "SAT";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // bakiyeLabel
            // 
            this.bakiyeLabel.AutoSize = true;
            this.bakiyeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bakiyeLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.bakiyeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bakiyeLabel.Location = new System.Drawing.Point(6, 21);
            this.bakiyeLabel.Name = "bakiyeLabel";
            this.bakiyeLabel.Size = new System.Drawing.Size(50, 29);
            this.bakiyeLabel.TabIndex = 5;
            this.bakiyeLabel.Text = "-- ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Cüzdan Değeri:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.transferlerDatgrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transferler:";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // transferlerDatgrid
            // 
            this.transferlerDatgrid.AllowDrop = true;
            this.transferlerDatgrid.AllowUserToAddRows = false;
            this.transferlerDatgrid.AllowUserToDeleteRows = false;
            this.transferlerDatgrid.AllowUserToOrderColumns = true;
            this.transferlerDatgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transferlerDatgrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transferlerDatgrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.transferlerDatgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferlerDatgrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.transferlerDatgrid.GridColor = System.Drawing.Color.Plum;
            this.transferlerDatgrid.Location = new System.Drawing.Point(3, 3);
            this.transferlerDatgrid.MultiSelect = false;
            this.transferlerDatgrid.Name = "transferlerDatgrid";
            this.transferlerDatgrid.ReadOnly = true;
            this.transferlerDatgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transferlerDatgrid.ShowEditingIcon = false;
            this.transferlerDatgrid.Size = new System.Drawing.Size(911, 285);
            this.transferlerDatgrid.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lastOrdersDatagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(917, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Son Emirler:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lastOrdersDatagrid
            // 
            this.lastOrdersDatagrid.AllowDrop = true;
            this.lastOrdersDatagrid.AllowUserToAddRows = false;
            this.lastOrdersDatagrid.AllowUserToDeleteRows = false;
            this.lastOrdersDatagrid.AllowUserToOrderColumns = true;
            this.lastOrdersDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lastOrdersDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.lastOrdersDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lastOrdersDatagrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.lastOrdersDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastOrdersDatagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lastOrdersDatagrid.GridColor = System.Drawing.Color.Plum;
            this.lastOrdersDatagrid.Location = new System.Drawing.Point(3, 3);
            this.lastOrdersDatagrid.MultiSelect = false;
            this.lastOrdersDatagrid.Name = "lastOrdersDatagrid";
            this.lastOrdersDatagrid.ReadOnly = true;
            this.lastOrdersDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lastOrdersDatagrid.ShowEditingIcon = false;
            this.lastOrdersDatagrid.Size = new System.Drawing.Size(911, 285);
            this.lastOrdersDatagrid.TabIndex = 2;
            // 
            // kullancıAdLabel
            // 
            this.kullancıAdLabel.AutoSize = true;
            this.kullancıAdLabel.BackColor = System.Drawing.Color.Transparent;
            this.kullancıAdLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.kullancıAdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kullancıAdLabel.Location = new System.Drawing.Point(12, 3);
            this.kullancıAdLabel.Name = "kullancıAdLabel";
            this.kullancıAdLabel.Size = new System.Drawing.Size(186, 29);
            this.kullancıAdLabel.TabIndex = 8;
            this.kullancıAdLabel.Text = "Name Surname";
            // 
            // kullaniciTipiLabel
            // 
            this.kullaniciTipiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kullaniciTipiLabel.BackColor = System.Drawing.Color.Transparent;
            this.kullaniciTipiLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.kullaniciTipiLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.kullaniciTipiLabel.Location = new System.Drawing.Point(606, 13);
            this.kullaniciTipiLabel.Name = "kullaniciTipiLabel";
            this.kullaniciTipiLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullaniciTipiLabel.Size = new System.Drawing.Size(327, 16);
            this.kullaniciTipiLabel.TabIndex = 9;
            this.kullaniciTipiLabel.Text = "----- User";
            this.kullaniciTipiLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 753);
            this.Controls.Add(this.kullaniciTipiLabel);
            this.Controls.Add(this.kullancıAdLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainItemsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main_form";
            this.Text = "İşlem Ekranı";
            this.Load += new System.EventHandler(this.main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainItemsDataGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDatagrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transferlerDatgrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lastOrdersDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainItemsDataGrid;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView urunlerDatagrid;
        private System.Windows.Forms.Label bakiyeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView transferlerDatgrid;
        private System.Windows.Forms.Label kullancıAdLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private System.Windows.Forms.Label kullaniciTipiLabel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView lastOrdersDatagrid;
        private System.Windows.Forms.DataGridViewButtonColumn butButton;
        private System.Windows.Forms.DataGridViewButtonColumn sellButton;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button userInfoButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adminButton;
    }
}