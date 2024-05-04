namespace DrystalAirport.Forms
{
    partial class FlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.directionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new DrystalAirport.AirportDataSet();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.airlinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.goLastButton = new System.Windows.Forms.Button();
            this.goFirstButton = new System.Windows.Forms.Button();
            this.goNextButton = new System.Windows.Forms.Button();
            this.maxIndexLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.airlinesComboBox = new System.Windows.Forms.ComboBox();
            this.airportComboBox = new System.Windows.Forms.ComboBox();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flightNameTextBox = new System.Windows.Forms.TextBox();
            this.airlinesLinkButton = new System.Windows.Forms.Button();
            this.airportsLinkButton = new System.Windows.Forms.Button();
            this.directionsLinkButton = new System.Windows.Forms.Button();
            this.tableAdapterManager = new DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager();
            this.tableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsTableAdapter();
            this.directionsTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.DirectionsTableAdapter();
            this.airportsTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.AirportsTableAdapter();
            this.airlinesTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.AirlinesTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.airlinesFilter = new System.Windows.Forms.ComboBox();
            this.airportFilter = new System.Windows.Forms.ComboBox();
            this.directionFilter = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.JournalTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.rollbackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 760);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(446, 692);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(660, 692);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(215, 45);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(6, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(886, 720);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlightName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код рейса";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DirectionID";
            this.dataGridViewTextBoxColumn2.DataSource = this.directionsBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "DirectionName";
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "Направление";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "DirectionID";
            // 
            // directionsBindingSource
            // 
            this.directionsBindingSource.DataMember = "Directions";
            this.directionsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AirportID";
            this.dataGridViewTextBoxColumn4.DataSource = this.airportsBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "AirportName";
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn4.HeaderText = "Аэропорт";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "AirportID";
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.airportDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AirlinesID";
            this.dataGridViewTextBoxColumn5.DataSource = this.airlinesBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "AirlinesName";
            this.dataGridViewTextBoxColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn5.HeaderText = "Авиакомпания";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "AirlinesID";
            // 
            // airlinesBindingSource
            // 
            this.airlinesBindingSource.DataMember = "Airlines";
            this.airlinesBindingSource.DataSource = this.airportDataSet;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Flights";
            this.bindingSource.DataSource = this.airportDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.indexTextBox);
            this.groupBox2.Controls.Add(this.goLastButton);
            this.groupBox2.Controls.Add(this.goFirstButton);
            this.groupBox2.Controls.Add(this.goNextButton);
            this.groupBox2.Controls.Add(this.maxIndexLabel);
            this.groupBox2.Controls.Add(this.goBackButton);
            this.groupBox2.Location = new System.Drawing.Point(916, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Навигация";
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(13, 79);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 35);
            this.indexTextBox.TabIndex = 10;
            // 
            // goLastButton
            // 
            this.goLastButton.Location = new System.Drawing.Point(312, 76);
            this.goLastButton.Name = "goLastButton";
            this.goLastButton.Size = new System.Drawing.Size(130, 40);
            this.goLastButton.TabIndex = 9;
            this.goLastButton.Text = "В конец";
            this.goLastButton.UseVisualStyleBackColor = true;
            this.goLastButton.Click += new System.EventHandler(this.goLastButton_Click);
            // 
            // goFirstButton
            // 
            this.goFirstButton.Location = new System.Drawing.Point(180, 76);
            this.goFirstButton.Name = "goFirstButton";
            this.goFirstButton.Size = new System.Drawing.Size(130, 40);
            this.goFirstButton.TabIndex = 8;
            this.goFirstButton.Text = "В начало";
            this.goFirstButton.UseVisualStyleBackColor = true;
            this.goFirstButton.Click += new System.EventHandler(this.goFirstButton_Click);
            // 
            // goNextButton
            // 
            this.goNextButton.Location = new System.Drawing.Point(227, 34);
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
            this.maxIndexLabel.Location = new System.Drawing.Point(122, 81);
            this.maxIndexLabel.Name = "maxIndexLabel";
            this.maxIndexLabel.Size = new System.Drawing.Size(52, 30);
            this.maxIndexLabel.TabIndex = 2;
            this.maxIndexLabel.Text = "из Х";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(10, 34);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(215, 40);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Предыдущая";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.declineButton);
            this.groupBox3.Controls.Add(this.acceptButton);
            this.groupBox3.Controls.Add(this.editButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.airlinesComboBox);
            this.groupBox3.Controls.Add(this.airportComboBox);
            this.groupBox3.Controls.Add(this.directionComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.flightNameTextBox);
            this.groupBox3.Location = new System.Drawing.Point(917, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Запись";
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(23, 194);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(150, 40);
            this.declineButton.TabIndex = 18;
            this.declineButton.Text = "Отменить";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Visible = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(179, 195);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(243, 40);
            this.acceptButton.TabIndex = 17;
            this.acceptButton.Text = " Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(23, 195);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(400, 40);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Аэропорт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Авиакомпания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Направление";
            // 
            // airlinesComboBox
            // 
            this.airlinesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "AirlinesID", true));
            this.airlinesComboBox.DataSource = this.airlinesBindingSource;
            this.airlinesComboBox.DisplayMember = "AirlinesName";
            this.airlinesComboBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlinesComboBox.FormattingEnabled = true;
            this.airlinesComboBox.Location = new System.Drawing.Point(179, 155);
            this.airlinesComboBox.Name = "airlinesComboBox";
            this.airlinesComboBox.Size = new System.Drawing.Size(244, 33);
            this.airlinesComboBox.TabIndex = 8;
            this.airlinesComboBox.ValueMember = "AirlinesID";
            this.airlinesComboBox.TextChanged += new System.EventHandler(this.airlinesComboBox_TextChanged);
            // 
            // airportComboBox
            // 
            this.airportComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "AirportID", true));
            this.airportComboBox.DataSource = this.airportsBindingSource;
            this.airportComboBox.DisplayMember = "AirportName";
            this.airportComboBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airportComboBox.FormattingEnabled = true;
            this.airportComboBox.Location = new System.Drawing.Point(179, 116);
            this.airportComboBox.Name = "airportComboBox";
            this.airportComboBox.Size = new System.Drawing.Size(243, 33);
            this.airportComboBox.TabIndex = 6;
            this.airportComboBox.ValueMember = "AirportID";
            this.airportComboBox.TextChanged += new System.EventHandler(this.airportComboBox_TextChanged);
            // 
            // directionComboBox
            // 
            this.directionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "DirectionID", true));
            this.directionComboBox.DataSource = this.directionsBindingSource;
            this.directionComboBox.DisplayMember = "DirectionName";
            this.directionComboBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(179, 77);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(243, 33);
            this.directionComboBox.TabIndex = 4;
            this.directionComboBox.ValueMember = "DirectionID";
            this.directionComboBox.TextChanged += new System.EventHandler(this.directionComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код рейса";
            // 
            // flightNameTextBox
            // 
            this.flightNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightName", true));
            this.flightNameTextBox.Location = new System.Drawing.Point(179, 35);
            this.flightNameTextBox.Name = "flightNameTextBox";
            this.flightNameTextBox.Size = new System.Drawing.Size(244, 35);
            this.flightNameTextBox.TabIndex = 0;
            this.flightNameTextBox.TextChanged += new System.EventHandler(this.airportNameTextBox_TextChanged);
            // 
            // airlinesLinkButton
            // 
            this.airlinesLinkButton.Location = new System.Drawing.Point(24, 109);
            this.airlinesLinkButton.Name = "airlinesLinkButton";
            this.airlinesLinkButton.Size = new System.Drawing.Size(399, 35);
            this.airlinesLinkButton.TabIndex = 9;
            this.airlinesLinkButton.Text = "Авиакомпании";
            this.airlinesLinkButton.UseVisualStyleBackColor = true;
            this.airlinesLinkButton.Click += new System.EventHandler(this.airlinesLinkButton_Click);
            // 
            // airportsLinkButton
            // 
            this.airportsLinkButton.Location = new System.Drawing.Point(24, 70);
            this.airportsLinkButton.Name = "airportsLinkButton";
            this.airportsLinkButton.Size = new System.Drawing.Size(399, 35);
            this.airportsLinkButton.TabIndex = 7;
            this.airportsLinkButton.Text = "Аэропорт";
            this.airportsLinkButton.UseVisualStyleBackColor = true;
            this.airportsLinkButton.Click += new System.EventHandler(this.airportsLinkButton_Click);
            // 
            // directionsLinkButton
            // 
            this.directionsLinkButton.Location = new System.Drawing.Point(24, 31);
            this.directionsLinkButton.Name = "directionsLinkButton";
            this.directionsLinkButton.Size = new System.Drawing.Size(399, 35);
            this.directionsLinkButton.TabIndex = 5;
            this.directionsLinkButton.Text = "Направления";
            this.directionsLinkButton.UseVisualStyleBackColor = true;
            this.directionsLinkButton.Click += new System.EventHandler(this.directionsLinkButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirlinesTableAdapter = null;
            this.tableAdapterManager.AirportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DirectionsTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.JournalTableAdapter = null;
            this.tableAdapterManager.StatusesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapter
            // 
            this.tableAdapter.ClearBeforeFill = true;
            // 
            // directionsTableAdapter
            // 
            this.directionsTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // airlinesTableAdapter
            // 
            this.airlinesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.airlinesFilter);
            this.groupBox5.Controls.Add(this.airportFilter);
            this.groupBox5.Controls.Add(this.directionFilter);
            this.groupBox5.Location = new System.Drawing.Point(917, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 163);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Аэропорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Авиакомпания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Направление";
            // 
            // airlinesFilter
            // 
            this.airlinesFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "AirlinesID", true));
            this.airlinesFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlinesFilter.FormattingEnabled = true;
            this.airlinesFilter.Location = new System.Drawing.Point(179, 112);
            this.airlinesFilter.Name = "airlinesFilter";
            this.airlinesFilter.Size = new System.Drawing.Size(243, 33);
            this.airlinesFilter.TabIndex = 8;
            this.airlinesFilter.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // airportFilter
            // 
            this.airportFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "AirportID", true));
            this.airportFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airportFilter.FormattingEnabled = true;
            this.airportFilter.Location = new System.Drawing.Point(179, 73);
            this.airportFilter.Name = "airportFilter";
            this.airportFilter.Size = new System.Drawing.Size(243, 33);
            this.airportFilter.TabIndex = 6;
            this.airportFilter.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // directionFilter
            // 
            this.directionFilter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "DirectionID", true));
            this.directionFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionFilter.FormattingEnabled = true;
            this.directionFilter.Location = new System.Drawing.Point(179, 34);
            this.directionFilter.Name = "directionFilter";
            this.directionFilter.Size = new System.Drawing.Size(243, 33);
            this.directionFilter.TabIndex = 4;
            this.directionFilter.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.airlinesLinkButton);
            this.groupBox4.Controls.Add(this.directionsLinkButton);
            this.groupBox4.Controls.Add(this.airportsLinkButton);
            this.groupBox4.Location = new System.Drawing.Point(916, 562);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 163);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Переход";
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataMember = "Journal";
            this.journalBindingSource.DataSource = this.airportDataSet;
            // 
            // journalTableAdapter
            // 
            this.journalTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1089, 734);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(277, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // rollbackButton
            // 
            this.rollbackButton.Location = new System.Drawing.Point(915, 734);
            this.rollbackButton.Name = "rollbackButton";
            this.rollbackButton.Size = new System.Drawing.Size(168, 45);
            this.rollbackButton.TabIndex = 12;
            this.rollbackButton.Text = "Откатить";
            this.rollbackButton.UseVisualStyleBackColor = true;
            this.rollbackButton.Click += new System.EventHandler(this.rollbackButton_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 791);
            this.Controls.Add(this.rollbackButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FlightsForm";
            this.Text = "Рейсы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.HandleFormLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label maxIndexLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flightNameTextBox;
        private System.Windows.Forms.Button goLastButton;
        private System.Windows.Forms.Button goFirstButton;
        private System.Windows.Forms.Button goNextButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox indexTextBox;
        private AirportDataSet airportDataSet;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bindingSource;
        private AirportDataSetTableAdapters.FlightsTableAdapter tableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource directionsBindingSource;
        private AirportDataSetTableAdapters.DirectionsTableAdapter directionsTableAdapter;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingSource airlinesBindingSource;
        private AirportDataSetTableAdapters.AirlinesTableAdapter airlinesTableAdapter;
        private System.Windows.Forms.Button directionsLinkButton;
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button airlinesLinkButton;
        private System.Windows.Forms.ComboBox airlinesComboBox;
        private System.Windows.Forms.Button airportsLinkButton;
        private System.Windows.Forms.ComboBox airportComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox airlinesFilter;
        private System.Windows.Forms.ComboBox airportFilter;
        private System.Windows.Forms.ComboBox directionFilter;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.BindingSource journalBindingSource;
        private AirportDataSetTableAdapters.JournalTableAdapter journalTableAdapter;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button rollbackButton;
    }
}