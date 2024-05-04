namespace DrystalAirport.ReportForms
{
    partial class AiportsReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AiportsReportForm));
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new DrystalAirport.AirportDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.airportsTableAdapter = new DrystalAirport.AirportDataSetTableAdapters.AirportsTableAdapter();
            this.printButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AirportsReportDataSet";
            reportDataSource1.Value = this.airportsBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "DrystalAirport.ReportForms.Reports.AirportsReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(3, 3);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1151, 709);
            this.reportViewer.TabIndex = 0;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // printButton
            // 
            this.printButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.Location = new System.Drawing.Point(3, 718);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(1151, 39);
            this.printButton.TabIndex = 8;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1177, 780);
            this.panel1.TabIndex = 9;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 760);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // AiportsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1177, 780);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AiportsReportForm";
            this.Text = "Перечень аэропортов";
            this.Load += new System.EventHandler(this.AiportsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}