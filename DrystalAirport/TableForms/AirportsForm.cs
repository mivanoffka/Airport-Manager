using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrystalAirport.ReportForms;

namespace DrystalAirport.Forms
{
    public partial class AirportsForm : Form
    {   
        public AirportsForm()
        {
            InitializeComponent();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            EndEditing();
            this.tableAdapter.Fill(this.airportDataSet.Airports);


            dataGridView_SelectionChanged(null, null);
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
            if (dataGridView.SelectedCells.Count > 0)
            {
                indexTextBox.Text = (dataGridView.SelectedCells[0].RowIndex + 1).ToString();
                maxIndexLabel.Text = "из " + (dataGridView.Rows.Count).ToString();
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataRowView row = bindingSource.AddNew() as DataRowView;
            row[1] = "[Новый аэропорт]";

            try
            {
                bindingSource.MovePrevious();
                bindingSource.MoveNext();
            }
            catch
            {
            }

            bindingSource.Position = bindingSource.IndexOf(row);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = bindingSource.Current as DataRowView;
            foreach (DataRow row in airportDataSet.Tables["Flights"].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    if (row[3].ToString() == currentRow[0].ToString())
                    {
                        MessageBox.Show("Невозможно удалить этот аэропорт, поскольку на него ссылаются записи таблице «Рейсы»", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

            bindingSource.RemoveCurrent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataSet);
        }

        private void HandleFormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            if (airportDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения перед выходом?", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (!Save())
                    {
                        e.Cancel = true;
                    }
                }
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }



        }

        private void airportNameTextBox_TextChanged(object sender, EventArgs e)
        {   
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];     
                row.Cells[1].Value = airportNameTextBox.Text;

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
            MessageBox.Show("Введены некорректные данные.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            (sender as DataGridView).CancelEdit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DrystalAirport.ReportForms.AiportsReportForm form = new AiportsReportForm();
            form.ShowDialog();
        }

        #region Правка записей

        string backUp;

        private void editButton_Click(object sender, EventArgs e)
        {
            StartEditing();
        }

        private void StartEditing()
        {
            rollbackButton.Enabled = false;
            backUp = airportNameTextBox.Text;
            dataGridView.DefaultCellStyle.ForeColor = Color.DarkGray;
            goNextButton.Enabled = false;
            goBackButton.Enabled = false;
            goFirstButton.Enabled = false;
            goLastButton.Enabled = false;
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            reportButton.Enabled = false;
            indexTextBox.Enabled = false;
            saveButton.Enabled = false;
            airportNameTextBox.Enabled = true;

            dataGridView.Enabled = false;

            declineButton.Visible = true;
            acceptButton.Visible = true;

            editButton.Visible = false;
        }

        private void EndEditing()
        {
            rollbackButton.Enabled = true;
            airportNameTextBox.Enabled = false;

            dataGridView.DefaultCellStyle.ForeColor = Color.Black;
            goNextButton.Enabled = true;
            goBackButton.Enabled = true;
            goFirstButton.Enabled = true;
            goLastButton.Enabled = true;
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            reportButton.Enabled = true;
            indexTextBox.Enabled = true;
            saveButton.Enabled = true;

            dataGridView.Enabled = true;

            declineButton.Visible = false;
            acceptButton.Visible = false;

            editButton.Visible = true;

            
            try
            {
                bindingSource.MoveNext();
                bindingSource.MovePrevious();
            }
            catch
            {
                try
                {
                    bindingSource.MovePrevious();
                    bindingSource.MoveNext();
 
                }
                catch
                {

                }
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            airportNameTextBox.Text = backUp;

            EndEditing();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            EndEditing();
        }

        #endregion

        private bool Save(bool notify = false)
        {
            if (!airportDataSet.HasChanges())
            {
                MessageBox.Show("Не обнаружено изменений, которые можно сохранить", "Сообщениe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            try
            {
                bindingSource.EndEdit();
                tableAdapter.Update(airportDataSet);
                if (notify)
                {
                    MessageBox.Show("Изменения успешно сохранены.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE KEY"))
                {
                    MessageBox.Show("Не удалось сохранить изменения. \n\nПрисутствуют повторяющиеся записи. Измените либо удалите их, чтобы таблицу можно было сохранить.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить изменения. \n\n" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }

            return true;
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            Save(true);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            EndEditing();
            this.tableAdapter.Fill(this.airportDataSet.Airports);

            dataGridView_SelectionChanged(null, null);
        }
    }
}
