namespace DrystalAirport.ReportForms
{
    partial class StatusesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusesReportForm));
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new DrystalAirport.AirportDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.airportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapter = new DrystalAirport.AirportDataSetTableAdapters.JournalExtendedViewTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.flightsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightsViewTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.FlightsViewTableAdapter();
            this.tableAdapterManager = new DrystalAirport.AirportDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsViewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "JournalExtendedView";
            this.bindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DrystalAirport.ReportForms.Reports.StatusReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(3, 3);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1224, 645);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // airportDataSetBindingSource
            // 
            this.airportDataSetBindingSource.DataSource = this.airportDataSet;
            this.airportDataSetBindingSource.Position = 0;
            // 
            // tableAdapter
            // 
            this.tableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(3, 654);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(1224, 39);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // flightsViewBindingSource
            // 
            this.flightsViewBindingSource.DataMember = "FlightsView";
            this.flightsViewBindingSource.DataSource = this.airportDataSet;
            // 
            // flightsViewTableAdapter
            // 
            this.flightsViewTableAdapter.ClearBeforeFill = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1250, 716);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.reportViewer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.printButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1230, 696);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // StatusesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 716);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatusesReportForm";
            this.Text = "Отчёт о статусе рейса";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsViewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource airportDataSetBindingSource;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource bindingSource;
        private AirportDataSetTableAdapters.JournalExtendedViewTableAdapter tableAdapter;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.BindingSource flightsViewBindingSource;
        private AirportDataSetTableAdapters.FlightsViewTableAdapter flightsViewTableAdapter;
        private AirportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}