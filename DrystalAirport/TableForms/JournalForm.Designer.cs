namespace DrystalAirport.Forms
{
    partial class JournalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flightsInfoViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new DrystalAirport.AirportDataSet();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.goLastButton = new System.Windows.Forms.Button();
            this.goFirstButton = new System.Windows.Forms.Button();
            this.goNextButton = new System.Windows.Forms.Button();
            this.maxIndexLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.flightDatePicker = new System.Windows.Forms.DateTimePicker();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.flightComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.statusesLinkButton = new System.Windows.Forms.Button();
            this.flightsLinkButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endCheckBox = new System.Windows.Forms.CheckBox();
            this.startCheckBox = new System.Windows.Forms.CheckBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusesFilter = new System.Windows.Forms.ComboBox();
            this.flightsFilter = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager();
            this.tableAdapter = new DrystalAirport.AirportDataSetTableAdapters.JournalTableAdapter();
            this.flightsTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsTableAdapter();
            this.statusesTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.StatusesTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.statusReportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rollbackButton = new System.Windows.Forms.Button();
            this.flightsInfoViewTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsInfoViewTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsInfoViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(11, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1164, 942);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Таблица";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(692, 863);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(212, 45);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(914, 863);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(215, 45);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView.DataSource = this.bindingSource;
            this.dataGridView.Location = new System.Drawing.Point(17, 34);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1128, 888);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError_1);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlightDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FlightTime";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Время";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FlightID";
            this.dataGridViewTextBoxColumn2.DataSource = this.flightsInfoViewBindingSource;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.DisplayMember = "FlightsInfo";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "Рейс";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "FlightID";
            // 
            // flightsInfoViewBindingSource
            // 
            this.flightsInfoViewBindingSource.DataMember = "FlightsInfoView";
            this.flightsInfoViewBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StatusID";
            this.dataGridViewTextBoxColumn5.DataSource = this.statusesBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "StatusName";
            this.dataGridViewTextBoxColumn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn5.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "StatusID";
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.airportDataSet;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "Journal";
            this.bindingSource.DataSource = this.airportDataSet;
            this.bindingSource.Sort = "flightDate, flightTime";
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airportDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.indexTextBox);
            this.groupBox2.Controls.Add(this.goLastButton);
            this.groupBox2.Controls.Add(this.goFirstButton);
            this.groupBox2.Controls.Add(this.goNextButton);
            this.groupBox2.Controls.Add(this.maxIndexLabel);
            this.groupBox2.Controls.Add(this.goBackButton);
            this.groupBox2.Location = new System.Drawing.Point(1181, 12);
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
            this.groupBox3.Controls.Add(this.timePicker);
            this.groupBox3.Controls.Add(this.flightDatePicker);
            this.groupBox3.Controls.Add(this.declineButton);
            this.groupBox3.Controls.Add(this.acceptButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.statusComboBox);
            this.groupBox3.Controls.Add(this.flightComboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dateTextBox);
            this.groupBox3.Controls.Add(this.editButton);
            this.groupBox3.Location = new System.Drawing.Point(1182, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 253);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Запись";
            // 
            // timePicker
            // 
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightTime", true));
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "FlightTime", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "t"));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(180, 75);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(245, 35);
            this.timePicker.TabIndex = 18;
            // 
            // flightDatePicker
            // 
            this.flightDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "FlightDate", true));
            this.flightDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightDate", true));
            this.flightDatePicker.Location = new System.Drawing.Point(180, 35);
            this.flightDatePicker.Name = "flightDatePicker";
            this.flightDatePicker.Size = new System.Drawing.Size(245, 35);
            this.flightDatePicker.TabIndex = 17;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(12, 196);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(161, 40);
            this.declineButton.TabIndex = 16;
            this.declineButton.Text = "Отменить";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Visible = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(178, 196);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(246, 40);
            this.acceptButton.TabIndex = 14;
            this.acceptButton.Text = " Применить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рейс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "StatusID", true));
            this.statusComboBox.DataSource = this.statusesBindingSource;
            this.statusComboBox.DisplayMember = "StatusName";
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(179, 155);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(244, 33);
            this.statusComboBox.TabIndex = 8;
            this.statusComboBox.ValueMember = "StatusID";
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            this.statusComboBox.TextChanged += new System.EventHandler(this.airlinesComboBox_TextChanged);
            // 
            // flightComboBox
            // 
            this.flightComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource, "FlightID", true));
            this.flightComboBox.DataSource = this.flightsBindingSource;
            this.flightComboBox.DisplayMember = "FlightName";
            this.flightComboBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightComboBox.FormattingEnabled = true;
            this.flightComboBox.Location = new System.Drawing.Point(179, 116);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(244, 33);
            this.flightComboBox.TabIndex = 6;
            this.flightComboBox.ValueMember = "FlightID";
            this.flightComboBox.TextChanged += new System.EventHandler(this.airportComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightDate", true));
            this.dateTextBox.Location = new System.Drawing.Point(179, 35);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(244, 35);
            this.dateTextBox.TabIndex = 0;
            this.dateTextBox.TextChanged += new System.EventHandler(this.airportNameTextBox_TextChanged);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(14, 196);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(411, 40);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // statusesLinkButton
            // 
            this.statusesLinkButton.Location = new System.Drawing.Point(22, 78);
            this.statusesLinkButton.Name = "statusesLinkButton";
            this.statusesLinkButton.Size = new System.Drawing.Size(398, 35);
            this.statusesLinkButton.TabIndex = 9;
            this.statusesLinkButton.Text = "Статусы";
            this.statusesLinkButton.UseVisualStyleBackColor = true;
            this.statusesLinkButton.Click += new System.EventHandler(this.statusesLinkButton_Click);
            // 
            // flightsLinkButton
            // 
            this.flightsLinkButton.Location = new System.Drawing.Point(22, 37);
            this.flightsLinkButton.Name = "flightsLinkButton";
            this.flightsLinkButton.Size = new System.Drawing.Size(398, 35);
            this.flightsLinkButton.TabIndex = 7;
            this.flightsLinkButton.Text = "Рейсы";
            this.flightsLinkButton.UseVisualStyleBackColor = true;
            this.flightsLinkButton.Click += new System.EventHandler(this.flightsLinkButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.endCheckBox);
            this.groupBox5.Controls.Add(this.startCheckBox);
            this.groupBox5.Controls.Add(this.endDatePicker);
            this.groupBox5.Controls.Add(this.startDatePicker);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.statusesFilter);
            this.groupBox5.Controls.Add(this.flightsFilter);
            this.groupBox5.Location = new System.Drawing.Point(1185, 406);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 209);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Фильтр";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "До";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "С";
            // 
            // endCheckBox
            // 
            this.endCheckBox.AutoSize = true;
            this.endCheckBox.Location = new System.Drawing.Point(29, 162);
            this.endCheckBox.Name = "endCheckBox";
            this.endCheckBox.Size = new System.Drawing.Size(22, 21);
            this.endCheckBox.TabIndex = 21;
            this.endCheckBox.UseVisualStyleBackColor = true;
            this.endCheckBox.CheckedChanged += new System.EventHandler(this.endTextBox_CheckedChanged);
            // 
            // startCheckBox
            // 
            this.startCheckBox.AutoSize = true;
            this.startCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startCheckBox.Location = new System.Drawing.Point(29, 122);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(44, 23);
            this.startCheckBox.TabIndex = 20;
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Location = new System.Drawing.Point(179, 153);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(243, 35);
            this.endDatePicker.TabIndex = 19;
            this.endDatePicker.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.Filter);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Location = new System.Drawing.Point(179, 112);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(243, 35);
            this.startDatePicker.TabIndex = 18;
            this.startDatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.Filter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Рейс";
            // 
            // statusesFilter
            // 
            this.statusesFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusesFilter.FormattingEnabled = true;
            this.statusesFilter.Location = new System.Drawing.Point(179, 73);
            this.statusesFilter.Name = "statusesFilter";
            this.statusesFilter.Size = new System.Drawing.Size(243, 33);
            this.statusesFilter.TabIndex = 6;
            this.statusesFilter.SelectedIndexChanged += new System.EventHandler(this.Filter);
            this.statusesFilter.Leave += new System.EventHandler(this.statusesFilter_Leave);
            // 
            // flightsFilter
            // 
            this.flightsFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flightsFilter.FormattingEnabled = true;
            this.flightsFilter.Location = new System.Drawing.Point(179, 34);
            this.flightsFilter.Name = "flightsFilter";
            this.flightsFilter.Size = new System.Drawing.Size(243, 33);
            this.flightsFilter.TabIndex = 4;
            this.flightsFilter.SelectedIndexChanged += new System.EventHandler(this.Filter);
            this.flightsFilter.Leave += new System.EventHandler(this.flightsFilter_Leave);
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
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.flightsLinkButton);
            this.groupBox4.Controls.Add(this.statusesLinkButton);
            this.groupBox4.Location = new System.Drawing.Point(1182, 621);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 142);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Переход к";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.scheduleButton);
            this.groupBox6.Controls.Add(this.statusReportButton);
            this.groupBox6.Location = new System.Drawing.Point(1182, 769);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(450, 134);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Отчётность";
            // 
            // scheduleButton
            // 
            this.scheduleButton.AutoEllipsis = true;
            this.scheduleButton.Location = new System.Drawing.Point(22, 37);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(398, 35);
            this.scheduleButton.TabIndex = 7;
            this.scheduleButton.Text = "Расписание";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // statusReportButton
            // 
            this.statusReportButton.Location = new System.Drawing.Point(22, 76);
            this.statusReportButton.Name = "statusReportButton";
            this.statusReportButton.Size = new System.Drawing.Size(398, 35);
            this.statusReportButton.TabIndex = 9;
            this.statusReportButton.Text = "Статус выбранного рейса";
            this.statusReportButton.UseVisualStyleBackColor = true;
            this.statusReportButton.Click += new System.EventHandler(this.statusReportButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1353, 909);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(278, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // rollbackButton
            // 
            this.rollbackButton.Location = new System.Drawing.Point(1181, 909);
            this.rollbackButton.Name = "rollbackButton";
            this.rollbackButton.Size = new System.Drawing.Size(168, 45);
            this.rollbackButton.TabIndex = 10;
            this.rollbackButton.Text = "Откатить";
            this.rollbackButton.UseVisualStyleBackColor = true;
            this.rollbackButton.Click += new System.EventHandler(this.rollbackButton_Click);
            // 
            // flightsInfoViewTableAdapter
            // 
            this.flightsInfoViewTableAdapter.ClearBeforeFill = true;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 973);
            this.Controls.Add(this.rollbackButton);
            this.Controls.Add(this.groupBox6);
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
            this.MaximizeBox = false;
            this.Name = "JournalForm";
            this.Text = "Журнал полётов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.HandleFormLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsInfoViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label maxIndexLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button goLastButton;
        private System.Windows.Forms.Button goFirstButton;
        private System.Windows.Forms.Button goNextButton;
        private System.Windows.Forms.TextBox indexTextBox;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statusesLinkButton;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button flightsLinkButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox statusesFilter;
        private System.Windows.Forms.ComboBox flightsFilter;
        private System.Windows.Forms.ComboBox flightComboBox;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AirportDataSetTableAdapters.JournalTableAdapter tableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirportDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private AirportDataSetTableAdapters.StatusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button statusReportButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker flightDatePicker;
        private System.Windows.Forms.Button rollbackButton;
        private System.Windows.Forms.CheckBox endCheckBox;
        private System.Windows.Forms.CheckBox startCheckBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource flightsInfoViewBindingSource;
        private AirportDataSetTableAdapters.FlightsInfoViewTableAdapter flightsInfoViewTableAdapter;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
    }
}