using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrystalAirport.ReportForms
{
    public partial class StatusesReportForm : Form
    {
        string flightName = "";
        public StatusesReportForm(string flightName, string flightDate, string flightTime, string flightStatus)
        {
            InitializeComponent();

            string currentTime = DateTime.Now.ToString();
            this.flightName = flightName;

            ReportParameter flightNameParam = new ReportParameter("FlightName", flightName);
            ReportParameter flightDateParam = new ReportParameter("FlightDate", flightDate);
            ReportParameter flightTimeParam = new ReportParameter("FlightTime", flightTime);
            ReportParameter flightStatusParam = new ReportParameter("FlightStatus", flightStatus);
            ReportParameter currentTimeParam = new ReportParameter("CurrentTime", currentTime);
         
            reportViewer.LocalReport.SetParameters(flightNameParam);
            reportViewer.LocalReport.SetParameters(flightDateParam);
            reportViewer.LocalReport.SetParameters(flightTimeParam);
            reportViewer.LocalReport.SetParameters(flightStatusParam);
            reportViewer.LocalReport.SetParameters(currentTimeParam);
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.FlightsView". При необходимости она может быть перемещена или удалена.
            this.flightsViewTableAdapter.Fill(this.airportDataSet.FlightsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.JournalExtendedView". При необходимости она может быть перемещена или удалена.
            this.tableAdapter.Fill(this.airportDataSet.JournalExtendedView);

            var rds = new ReportDataSource("StatusReport", airportDataSet.JournalExtendedView as DataTable);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);


            DataRow row = null;
            for (int i = 0; i < airportDataSet.Tables["FlightsView"].Rows.Count; i++)
            {
                //MessageBox.Show(airportDataSet.Tables["FlightsView"].Rows[i][1].ToString());
                if (airportDataSet.Tables["FlightsView"].Rows[i][0].ToString() == flightName)
                {
                    //MessageBox.Show("found!");
                    row = airportDataSet.Tables["FlightsView"].Rows[i];
                    break;
                }
            }

            string directionName = row[1].ToString();
            string airportName = row[2].ToString();
            string airlinesName = row[3].ToString();
            string flightInfo = "[ОШИБКА]";



            if (directionName == "Из")
            {
                flightInfo = airportName + " - Минск";
            }
            else
            {
                flightInfo = "Минск - " + airportName;
            }

            ReportParameter flightInfoParameter = new ReportParameter("FlightInfo", flightInfo);
            ReportParameter flightAirlinesParam = new ReportParameter("FlightAirlines", airlinesName);

            reportViewer.LocalReport.SetParameters(flightInfoParameter);
            reportViewer.LocalReport.SetParameters(flightAirlinesParam);

            this.reportViewer.RefreshReport();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Filter()
        {

        }


        private void DateChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void directionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            reportViewer.PrintDialog();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            reportViewer.PrintDialog();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
