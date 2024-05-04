using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrystalAirport.AirportDataSetTableAdapters;
using DrystalAirport.Forms;
using DrystalAirport.ReportForms;

namespace DrystalAirport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.JournalExtendedView". При необходимости она может быть перемещена или удалена.
            this.tableAdapter.Fill(this.airportDataSet.JournalExtendedView);
            inFlightsButton.Checked = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void airportsButton_Click(object sender, EventArgs e)
        {
            AirportsForm form = new AirportsForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);
        }

        private void directionsButton_Click(object sender, EventArgs e)
        {
            DirectionsForm form = new DirectionsForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlightsForm form = new FlightsForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void airlinesButton_Click(object sender, EventArgs e)
        {
            AirlinesForm form = new AirlinesForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);
        }

        private void statusesButton_Click(object sender, EventArgs e)
        {
            StatusesForm form = new StatusesForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            JournalForm form = new JournalForm();
            form.Owner = this;
            form.ShowDialog();
            form.Dispose();

            tableAdapter.Fill(airportDataSet.JournalExtendedView);
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            //this.dataGridView.Sort(dataGridView.Columns[3], ListSortDirection.Descending);

            //this.tableAdapter.Fill(this.airportDataSet.JournalExtendedView);



            bindingSource.Sort = "FlightDate DESC, FlightTime DESC";
            if (sender == inFlightsButton)
            {
                bindingSource.Filter = "DirectionFullName = 'Прилёты'";
                dataGridView.Columns[2].HeaderText = "Прибывает из";

            }
            else
            {
                bindingSource.Filter = "DirectionFullName = 'Вылеты'";
                dataGridView.Columns[2].HeaderText = "Направляется в";
            }

        }

        private void flightsFrequencyReportButton_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
