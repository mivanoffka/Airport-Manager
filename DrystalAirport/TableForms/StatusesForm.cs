using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrystalAirport.Forms
{
    public partial class StatusesForm : Form
    {   
        public StatusesForm()
        {
            InitializeComponent();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            this.tableAdapter.Fill(this.airportDataSet.Statuses);
        }
    }
}
