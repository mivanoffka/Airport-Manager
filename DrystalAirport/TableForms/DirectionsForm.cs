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
    public partial class DirectionsForm : Form
    {   
        public DirectionsForm()
        {
            InitializeComponent();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Directions". При необходимости она может быть перемещена или удалена.
            this.tableAdapter.Fill(this.airportDataSet.Directions);
        }
 
        private void goBackButton_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void goNextButton_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void goFirstButton_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
        }

        private void goLastButton_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            bindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataSet);
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            //var result = MessageBox.Show("Сохранить изменения?", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    saveButton_Click(null, null);
            //}
            //if (result == DialogResult.No)
            //{
            //    airportDataSet.RejectChanges();
            //}
            //if (result == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
            saveButton_Click_1(null, null);
        }

        private void airportNameTextBox_TextChanged(object sender, EventArgs e)
        {   
            if (dataGridView.SelectedRows.Count > 0)
           {
                DataGridViewRow row = dataGridView.SelectedRows[0];     
            } 

        }

        private void airportNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void HandleFormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void airlinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void directionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.airportDataSet);

        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            tableAdapter.Update(airportDataSet);
        }
    }
}
