namespace DrystalAirport.Forms
{
    partial class JournalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.к
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
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.goLastButton = new System.Windows.Forms.Button();
            this.goFirstButton = new System.Windows.Forms.Button();
            this.goNextButton = new System.Windows.Forms.Button();
            this.maxIndexLabel = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.flightComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.statusesLinkButton = new System.Windows.Forms.Button();
            this.flightsLinkButton = new System.Windows.Forms.Button();
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
            this.scheduleButton = new System.Windows.Forms.Button();
            this.statusReportButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.rollbackButton = new System.Windows.Forms.Button();
            this.flightsInfoViewTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsInfoViewTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsInfoViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
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
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(5, 5);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(1157, 963);
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
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(6, 55);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 35);
            this.indexTextBox.TabIndex = 10;
            // 
            // goLastButton
            // 
            this.goLastButton.Location = new System.Drawing.Point(305, 52);
            this.goLastButton.Name = "goLastButton";
            this.goLastButton.Size = new System.Drawing.Size(130, 40);
            this.goLastButton.TabIndex = 9;
            this.goLastButton.Text = "В конец";
            this.goLastButton.UseVisualStyleBackColor = true;
            this.goLastButton.Click += new System.EventHandler(this.goLastButton_Click);
            // 
            // goFirstButton
            // 
            this.goFirstButton.Location = new System.Drawing.Point(173, 52);
            this.goFirstButton.Name = "goFirstButton";
            this.goFirstButton.Size = new System.Drawing.Size(130, 40);
            this.goFirstButton.TabIndex = 8;
            this.goFirstButton.Text = "В начало";
            this.goFirstButton.UseVisualStyleBackColor = true;
            this.goFirstButton.Click += new System.EventHandler(this.goFirstButton_Click);
            // 
            // goNextButton
            // 
            this.goNextButton.Location = new System.Drawing.Point(220, 10);
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
            this.maxIndexLabel.Location = new System.Drawing.Point(115, 57);
            this.maxIndexLabel.Name = "maxIndexLabel";
            this.maxIndexLabel.Size = new System.Drawing.Size(52, 30);
            this.maxIndexLabel.TabIndex = 2;
            this.maxIndexLabel.Text = "из Х";
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(3, 10);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(215, 40);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Предыдущая";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightTime", true));
            this.timePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "FlightTime", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "t"));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(177, 52);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(245, 35);
            this.timePicker.TabIndex = 18;
            // 
            // datePicker
            // 
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource, "FlightDate", true));
            this.datePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "FlightDate", true));
            this.datePicker.Location = new System.Drawing.Point(177, 12);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 35);
            this.datePicker.TabIndex = 17;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(9, 173);
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
            this.acceptButton.Location = new System.Drawing.Point(175, 173);
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
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рейс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Статус";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
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
            this.statusComboBox.Location = new System.Drawing.Point(176, 132);
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
            this.flightComboBox.Location = new System.Drawing.Point(176, 93);
            this.flightComboBox.Name = "flightComboBox";
            this.flightComboBox.Size = new System.Drawing.Size(244, 33);
            this.flightComboBox.TabIndex = 6;
            this.flightComboBox.ValueMember = "FlightID";
            this.flightComboBox.TextChanged += new System.EventHandler(this.airportComboBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(11, 173);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(411, 40);
            this.editButton.TabIndex = 15;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // statusesLinkButton
            // 
            this.statusesLinkButton.Location = new System.Drawing.Point(18, 52);
            this.statusesLinkButton.Name = "statusesLinkButton";
            this.statusesLinkButton.Size = new System.Drawing.Size(398, 35);
            this.statusesLinkButton.TabIndex = 9;
            this.statusesLinkButton.Text = "Статусы";
            this.statusesLinkButton.UseVisualStyleBackColor = true;
            this.statusesLinkButton.Click += new System.EventHandler(this.statusesLinkButton_Click);
            // 
            // flightsLinkButton
            // 
            this.flightsLinkButton.Location = new System.Drawing.Point(18, 11);
            this.flightsLinkButton.Name = "flightsLinkButton";
            this.flightsLinkButton.Size = new System.Drawing.Size(398, 35);
            this.flightsLinkButton.TabIndex = 7;
            this.flightsLinkButton.Text = "Рейсы";
            this.flightsLinkButton.UseVisualStyleBackColor = true;
            this.flightsLinkButton.Click += new System.EventHandler(this.flightsLinkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "До";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 30);
            this.label6.TabIndex = 22;
            this.label6.Text = "С";
            // 
            // endCheckBox
            // 
            this.endCheckBox.AutoSize = true;
            this.endCheckBox.Location = new System.Drawing.Point(23, 145);
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
            this.startCheckBox.Location = new System.Drawing.Point(23, 105);
            this.startCheckBox.Name = "startCheckBox";
            this.startCheckBox.Size = new System.Drawing.Size(44, 23);
            this.startCheckBox.TabIndex = 20;
            this.startCheckBox.UseVisualStyleBackColor = true;
            this.startCheckBox.CheckedChanged += new System.EventHandler(this.startCheckBox_CheckedChanged);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Location = new System.Drawing.Point(173, 136);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(243, 35);
            this.endDatePicker.TabIndex = 19;
            this.endDatePicker.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.ValueChanged += new System.EventHandler(this.Filter);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Location = new System.Drawing.Point(173, 95);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(243, 35);
            this.startDatePicker.TabIndex = 18;
            this.startDatePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startDatePicker.ValueChanged += new System.EventHandler(this.Filter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 10;
            this.label7.Text = "Рейс";
            // 
            // statusesFilter
            // 
            this.statusesFilter.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusesFilter.FormattingEnabled = true;
            this.statusesFilter.Location = new System.Drawing.Point(173, 56);
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
            this.flightsFilter.Location = new System.Drawing.Point(173, 17);
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
            // scheduleButton
            // 
            this.scheduleButton.AutoEllipsis = true;
            this.scheduleButton.Location = new System.Drawing.Point(19, 12);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(398, 35);
            this.scheduleButton.TabIndex = 7;
            this.scheduleButton.Text = "Расписание";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // statusReportButton
            // 
            this.statusReportButton.Location = new System.Drawing.Point(22, 53);
            this.statusReportButton.Name = "statusReportButton";
            this.statusReportButton.Size = new System.Drawing.Size(398, 35);
            this.statusReportButton.TabIndex = 9;
            this.statusReportButton.Text = "Статус выбранного рейса";
            this.statusReportButton.UseVisualStyleBackColor = true;
            this.statusReportButton.Click += new System.EventHandler(this.statusReportButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(156, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(282, 45);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // rollbackButton
            // 
            this.rollbackButton.Location = new System.Drawing.Point(6, 4);
            this.rollbackButton.Name = "rollbackButton";
            this.rollbackButton.Size = new System.Drawing.Size(146, 45);
            this.rollbackButton.TabIndex = 10;
            this.rollbackButton.Text = "Откатить";
            this.rollbackButton.UseVisualStyleBackColor = true;
            this.rollbackButton.Click += new System.EventHandler(this.rollbackButton_Click);
            // 
            // flightsInfoViewTableAdapter
            // 
            this.flightsInfoViewTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1654, 1023);
            this.panel1.TabIndex = 14;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1644, 1013);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1178, 1007);
            this.panel2.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(5, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1173, 1007);
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
            this.panel4.Size = new System.Drawing.Size(1167, 973);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 889);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1151, 76);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.deleteButton, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(654, 3);
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
            this.panel3.Location = new System.Drawing.Point(1187, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(454, 1007);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 1007);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 810);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчётность";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.scheduleButton);
            this.panel10.Controls.Add(this.statusReportButton);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(3, 31);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(437, 100);
            this.panel10.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.panel9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 648);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(443, 156);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Переход";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.flightsLinkButton);
            this.panel9.Controls.Add(this.statusesLinkButton);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 31);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(437, 103);
            this.panel9.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.panel7);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 408);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(443, 234);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Фильтр";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.statusesFilter);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.flightsFilter);
            this.panel7.Controls.Add(this.endCheckBox);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.startCheckBox);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.endDatePicker);
            this.panel7.Controls.Add(this.startDatePicker);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(437, 197);
            this.panel7.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel6);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 138);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(443, 264);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Запись";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.timePicker);
            this.panel6.Controls.Add(this.declineButton);
            this.panel6.Controls.Add(this.datePicker);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.flightComboBox);
            this.panel6.Controls.Add(this.acceptButton);
            this.panel6.Controls.Add(this.statusComboBox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.editButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 223);
            this.panel6.TabIndex = 0;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.indexTextBox);
            this.panel5.Controls.Add(this.goBackButton);
            this.panel5.Controls.Add(this.goLastButton);
            this.panel5.Controls.Add(this.maxIndexLabel);
            this.panel5.Controls.Add(this.goFirstButton);
            this.panel5.Controls.Add(this.goNextButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 95);
            this.panel5.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rollbackButton);
            this.panel8.Controls.Add(this.saveButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 950);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(443, 54);
            this.panel8.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(13, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(231, 44);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(250, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(231, 44);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1654, 1023);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JournalForm";
            this.Text = "Журнал полётов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandleFormClosing);
            this.Load += new System.EventHandler(this.HandleFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsInfoViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
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
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label maxIndexLabel;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Button statusReportButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker datePicker;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
    }
}