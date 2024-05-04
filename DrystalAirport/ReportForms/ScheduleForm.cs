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
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airlines". При необходимости она может быть перемещена или удалена.
            this.airlinesTableAdapter.Fill(this.airportDataSet.Airlines);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Flights". При необходимости она может быть перемещена или удалена.
            //this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.JournalExtendedView". При необходимости она может быть перемещена или удалена.
            this.tableAdapter.Fill(this.airportDataSet.JournalExtendedView);

            this.reportViewer.RefreshReport();

            dateTimePicker.Value = DateTime.Today;


            List<string> airlines = new List<string>();
            airlinesComboBox.Text = "[Все авиакомпании]";
            airlinesComboBox.Items.Add("[Все авиакомпании]");
            for (int i = 0; i < airportDataSet.Tables["Airlines"].Rows.Count; i++)
            {
                airlinesComboBox.Items.Add(airportDataSet.Tables["Airlines"].Rows[i][1].ToString());
            }

            //dateTimePickerEnd.Value = DateTime.Today.AddDays(1);

            //directionComboBox.SelectedIndex = 0;

            Filter();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Filter()
        {
            DateTime dateBegin = dateTimePicker.Value;
            //DateTime dateEnd = dateTimePickerEnd.Value;

            string dateBeginStr = dateBegin.ToString();
            dateBeginStr = dateBeginStr.Replace("0:00:00", "");
            //string dateEndStr = dateEnd.ToString();

            //string directionName = directionComboBox.SelectedIndex == 1 ? "В" : "Из";

            //string filter = "FlightDate >= '" + dateBeginStr + "' and FlightDate <= '" + dateEndStr + "'" + "and DirectionName = '" + directionName + "'";
            ReportParameter date = new ReportParameter("Date", dateBeginStr);
            reportViewer.LocalReport.SetParameters(date);
            string filter = "FlightDate = '" + dateBeginStr + "'";
            if (airlinesComboBox.Text != "[Все авиакомпании]")
            {
                filter += "and AirlinesName = '" + airlinesComboBox.Text + "'"; 
            }


            bindingSource.Filter = filter;
            bindingSource.Sort = "FlightTime";
            reportViewer.RefreshReport();
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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void airlinesComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
