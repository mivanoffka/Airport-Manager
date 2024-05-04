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
    public partial class AiportsReportForm : Form
    {
        public AiportsReportForm()
        {
            InitializeComponent();
        }

        private void AiportsReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);

            this.reportViewer.RefreshReport();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            reportViewer.PrintDialog();
        }
    }
}
