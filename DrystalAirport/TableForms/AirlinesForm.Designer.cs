namespace DrystalAirport.Forms
{
    partial class AirlinesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirlinesForm));
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new DrystalAirport.AirportDataSet();
            this.acceptButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.airlinesNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.tableAdapter = new DrystalAirport.AirportDataSetTableAdapters.AirlinesTableAdapter();
            this.tableAdapterManager = new DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsTableAdapter();
            this.rollbackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.goNextButton = new System.Windows.Forms.Button();
            this.maxIndexLabel = new System.Windows.Forms.Label();
            this.goFirstButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.goLastButton = new System.Windows.Forms.Button();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.declineButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(250, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(231, 44);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(13, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 44);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(509, 676);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AirlinesID";
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AirlinesName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Авиакомпания";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Airlines";
            this.bindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(174, 52);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(246, 40);
            this.acceptButton.TabIndex = 19;
            this.acceptButton.Text = " Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(18, 52);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(400, 40);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Авиакомпания";
            // 
            // airlinesNameTextBox
            // 
            this.airlinesNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "AirlinesName", true));
            this.airlinesNameTextBox.Location = new System.Drawing.Point(174, 11);
            this.airlinesNameTextBox.Name = "airlinesNameTextBox";
            this.airlinesNameTextBox.Size = new System.Drawing.Size(244, 35);
            this.airlinesNameTextBox.TabIndex = 0;
            this.airlinesNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.airportNameTextBox_MouseClick);
            this.airlinesNameTextBox.TextChanged += new System.EventHandler(this.airportNameTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(158, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(278, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // tableAdapter
            // 
            this.tableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirlinesTableAdapter = this.tableAdapter;
            this.tableAdapterManager.AirportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DirectionsTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.StatusesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airportDataSet;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // rollbackButton
            // 
            this.rollbackButton.Location = new System.Drawing.Point(11, 4);
            this.rollbackButton.Name = "rollbackButton";
            this.rollbackButton.Size = new System.Drawing.Size(141, 45);
            this.rollbackButton.TabIndex = 21;
            this.rollbackButton.Text = "Откатить";
            this.rollbackButton.UseVisualStyleBackColor = true;
            this.rollbackButton.Click += new System.EventHandler(this.rollbackButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1006, 736);
            this.panel1.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 726);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(530, 720);
            this.panel2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(5, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(525, 720);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Таблица";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 31);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(519, 686);
            this.panel4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 602);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(503, 76);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.deleteButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(494, 70);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(539, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(454, 720);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 449F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 720);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel6);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 138);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(443, 519);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Запись";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.declineButton);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.acceptButton);
            this.panel6.Controls.Add(this.airlinesNameTextBox);
            this.panel6.Controls.Add(this.editButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 105);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rollbackButton);
            this.panel8.Controls.Add(this.saveButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 663);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(443, 54);
            this.panel8.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AirlinesID";
            this.dataGridViewTextBoxColumn5.HeaderText = "AirlinesID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 9;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AirlinesName";
            this.dataGridViewTextBoxColumn6.HeaderText = "AirlinesName";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.indexTextBox);
            this.panel5.Controls.Add(this.goLastButton);
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Controls.Add(this.goFirstButton);
            this.panel5.Controls.Add(this.maxIndexLabel);
            this.panel5.Controls.Add(this.goNextButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 95);
            this.panel5.TabIndex = 0;
            // 
            // goNextButton
            // 
            this.goNextButton.Location = new System.Drawing.Point(219, 7);
            this.goNextButton.Name = "goNextButton";
            this.goNextButton.Size = new System.Drawing.Size(215, 40);
            this.goNextButton.TabIndex = 7;
            this.goNextButton.Text = "Следующая";
            this.goNextButton.UseVisualStyleBackColor = true;
            this.goNextButton.Click += new System.EventHandler(this.goNextButton_Click);
            // 
            // maxIndexLabel
            // 
            this.maxIndexLabel.AutoSize = true;
            this.maxIndexLabel.Location = new System.Drawing.Point(114, 54);
            this.maxIndexLabel.Name = "maxIndexLabel";
            this.maxIndexLabel.Size = new System.Drawing.Size(52, 30);
            this.maxIndexLabel.TabIndex = 2;
            this.maxIndexLabel.Text = "из Х";
            // 
            // goFirstButton
            // 
            this.goFirstButton.Location = new System.Drawing.Point(172, 49);
            this.goFirstButton.Name = "goFirstButton";
            this.goFirstButton.Size = new System.Drawing.Size(130, 40);
            this.goFirstButton.TabIndex = 8;
            this.goFirstButton.Text = "В начало";
            this.goFirstButton.UseVisualStyleBackColor = true;
            this.goFirstButton.Click += new System.EventHandler(this.goFirstButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(2, 7);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(215, 40);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Предыдущая";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // goLastButton
            // 
            this.goLastButton.Location = new System.Drawing.Point(304, 49);
            this.goLastButton.Name = "goLastButton";
            this.goLastButton.Size = new System.Drawing.Size(130, 40);
            this.goLastButton.TabIndex = 9;
            this.goLastButton.Text = "В конец";
            this.goLastButton.UseVisualStyleBackColor = true;
            this.goLastButton.Click += new System.EventHandler(this.goLastButton_Click);
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(5, 52);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 35);
            this.indexTextBox.TabIndex = 10;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.panel5);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(443, 129);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Навигация";
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(16, 52);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(151, 40);
            this.declineButton.TabIndex = 20;
            this.declineButton.Text = "Отменить";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Visible = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // AirlinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1006, 736);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AirlinesForm";
            this.Text = "Авиакомпании";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HandleFormClosed);
            this.Load += new System.EventHandler(this.HandleFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox airlinesNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource bindingSource;
        private AirportDataSetTableAdapters.AirlinesTableAdapter tableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirportDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.Button rollbackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Button goLastButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button goFirstButton;
        private System.Windows.Forms.Label maxIndexLabel;
        private System.Windows.Forms.Button goNextButton;
        private System.Windows.Forms.Button declineButton;
    }
}