using DrystalAirport.ReportForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrystalAirport.Forms
{
    public partial class JournalForm : Form
    {   
        public JournalForm()
        {
            InitializeComponent();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.FlightsInfoView". При необходимости она может быть перемещена или удалена.
            this.flightsInfoViewTableAdapter.Fill(this.airportDataSet.FlightsInfoView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.FlightsView". При необходимости она может быть перемещена или удалена.
            EndEditing();


            this.statusesTableAdapter.Fill(this.airportDataSet.Statuses);
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            this.tableAdapter.Fill(this.airportDataSet.Journal);

            foreach (DataColumn column in airportDataSet.Journal.Columns)
            {
                column.AllowDBNull = true;
            }

            UpdateFlightsFilter();
            UpdateStatusesFilter();

            bindingSource.Sort = "FlightDate DESC, FlightTime DESC";
            dataGridView_SelectionChanged(null, null);

        }

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

        #region Элементы управления

        private void ShowWarning()
        {
            MessageBox.Show("Прежде чем совершить данное действие, необходимо либо заполнить текущую запись корректными данными, либо удалить её.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.MovePrevious();
            }
            catch
            {
                ShowWarning();
            }

        }

        private void goNextButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.MoveNext();
            }
            catch
            {
                ShowWarning();
            }
        }

        private void goFirstButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.MoveFirst();
            }
            catch
            {
                ShowWarning();
            }
        }

        private void goLastButton_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource.MoveLast();
            }
            catch
            {
                ShowWarning();
            }
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
       
            row[1] = 0;
            row[2] = DateTime.Now.ToString("d");
            row[3] = "00:00:00";
            row[4] = 0;

            try
            {
                bindingSource.MovePrevious();
                bindingSource.MoveNext();
            }
            catch
            {
            }
            
            bindingSource.Position = bindingSource.IndexOf(row);
            
            dataGridView_SelectionChanged(null, null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bindingSource.RemoveCurrent();

            dataGridView_SelectionChanged(null, null);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(airportDataSet);
        }

        #endregion

        #region Обратная связь между таблицей и полями, отобр. выбр. строку

        private void airportNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if (dataGridView.Rows.Count <= 1)
            {
                return;
            }
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
            }

        }
        private void airportComboBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 1)
            {
                return;
            }

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                row.Cells[3].Value = flightComboBox.Text;
            }
        }
        private void airlinesComboBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 1)
            {
                return;
            }

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                row.Cells[4].Value = statusComboBox.Text;
            }
        }

        #endregion

        #region Фильтрация

        List<KeyValuePair<int, string>> flightsKeyValuePairs;
        List<KeyValuePair<int, string>> statusesKeyValuePairs;
        string anyKey = "(Не важно)";

        private void UpdateFlightsFilter()
        {
            List<KeyValuePair<int, string>> keyValuePairs = new List<KeyValuePair<int, string>>();
            keyValuePairs.Add(new KeyValuePair<int, string>(-1, anyKey));
            foreach (DataRowView row in flightComboBox.Items)
            {   
                keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(row[0]), Convert.ToString(row[2])));
            }

            flightsKeyValuePairs = keyValuePairs;
            var list = DictionaryHelper.GetValues(keyValuePairs);

            

            flightsFilter.Items.Clear();

            foreach (string value in list)
            {
                flightsFilter.Items.Add(value);
            }
            flightsFilter.Text = anyKey;

        }

        private void UpdateStatusesFilter()
        {
            List<KeyValuePair<int, string>> keyValuePairs = new List<KeyValuePair<int, string>>();
            keyValuePairs.Add(new KeyValuePair<int, string>(-1, anyKey));
            foreach (DataRowView row in statusComboBox.Items)
            {
                keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(row[0]), Convert.ToString(row[1])));
            }

            statusesKeyValuePairs = keyValuePairs;
            var list = DictionaryHelper.GetValues(keyValuePairs);
 
            statusesFilter.Items.Clear();
            foreach (string value in list)
            {
                statusesFilter.Items.Add(value);
            }
            statusesFilter.Text = anyKey;
  
        }

        private void Filter(object sender, EventArgs e)
        {
            if (flightsKeyValuePairs == null || statusesKeyValuePairs == null)
            {
                return;
            }
            dataGridView.Select();
            string rowFilter = "";
            string flightRowFilter = "";
            string statusesRowFilter = "";
            string startTimeFilter = "";
            string endTimeFilter = "";

            if (flightsFilter.Text != anyKey)
            {
                int key = DictionaryHelper.GetKey(flightsKeyValuePairs, flightsFilter.Text);
                flightRowFilter = "FlightID = " + key;
            }

            if (statusesFilter.Text != anyKey)
            {
                int key = DictionaryHelper.GetKey(statusesKeyValuePairs, statusesFilter.Text);
                statusesRowFilter = "StatusID = " + key;
            }

            if (startCheckBox.Checked)
            {
                startTimeFilter = "flightDate >= #" + startDatePicker.Value.ToString("yyyy-MM-dd") + "#";
            }

            if (endCheckBox.Checked)
            {
                endTimeFilter = "flightDate <= #" + endDatePicker.Value.ToString("yyyy-MM-dd") + "#";
            }

            rowFilter += flightRowFilter;
            if (statusesRowFilter != "")
                rowFilter += rowFilter == "" ? statusesRowFilter : " and " + statusesRowFilter;
            if (startTimeFilter != "")
                rowFilter += rowFilter == "" ? startTimeFilter : " and " + startTimeFilter;
            if (endTimeFilter != "")
                rowFilter += rowFilter == "" ? endTimeFilter : " and " + endTimeFilter;

            bindingSource.Filter = rowFilter;
            bindingSource.MoveFirst();

            dataGridView_SelectionChanged(null, null);

        }

        #endregion

        #region Переход к другим формам и обновление данных

        private void flightsLinkButton_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            FlightsForm form = new FlightsForm();
            form.ShowDialog(this);
            form.Dispose();

            this.flightsTableAdapter.Fill(airportDataSet.Flights);
            this.flightsInfoViewTableAdapter.Fill(airportDataSet.FlightsInfoView);
            UpdateFlightsFilter();
        }

        private void statusesLinkButton_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            StatusesForm form = new StatusesForm();
            form.ShowDialog(this);
            form.Dispose();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            ScheduleForm form = new ScheduleForm();
            form.ShowDialog();
        }

        private void statusReportButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                StatusesReportForm form = new StatusesReportForm(flightComboBox.Text, datePicker.Text, timePicker.Text, statusComboBox.Text);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не выбран рейс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Правка записей

        string[] backUp;

        private void editButton_Click(object sender, EventArgs e)
        {
            StartEditing();
        }

        private void StartEditing()
        {
            backUp = new string[4] {statusComboBox.Text, flightComboBox.Text, timePicker.Text, datePicker.Text};

            goNextButton.Enabled = false;
            goBackButton.Enabled = false;
            goFirstButton.Enabled = false;
            goLastButton.Enabled = false;
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            scheduleButton.Enabled = false;
            statusReportButton.Enabled = false;
            flightsLinkButton.Enabled = false;
            statusesLinkButton.Enabled = false;
            indexTextBox.Enabled = false;
            saveButton.Enabled = false;
            flightsFilter.Enabled = false;
            statusesFilter.Enabled = false;
            rollbackButton.Enabled = false;
            
            datePicker.Enabled = true;

            statusComboBox.Enabled = true;
            flightComboBox.Enabled = true;
            timePicker.Enabled = true;

            dataGridView.Enabled = false;
       
            dataGridView.DefaultCellStyle.ForeColor = Color.DarkGray;

            declineButton.Visible = true;
            acceptButton.Visible = true;

            editButton.Visible = false;
        }

        private void EndEditing()
        {
            statusComboBox.Enabled = false;
            flightComboBox.Enabled = false;
            timePicker.Enabled = false;
            datePicker.Enabled = false;

            goNextButton.Enabled = true;
            goBackButton.Enabled = true;
            goFirstButton.Enabled = true;
            goLastButton.Enabled = true;
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            scheduleButton.Enabled = true;
            statusReportButton.Enabled = true;
            flightsLinkButton.Enabled = true;
            statusesLinkButton.Enabled = true;
            indexTextBox.Enabled = true;
            flightsFilter.Enabled = true;
            statusesFilter.Enabled = true;
            saveButton.Enabled = true;
            rollbackButton.Enabled = true;

            dataGridView.Enabled = true;

            declineButton.Visible = false;
            acceptButton.Visible = false;

            editButton.Visible = true;

            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

            try
            {
                bindingSource.MoveNext();
                bindingSource.MovePrevious();
            }
            catch
            {
                ShowWarning();
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            statusComboBox.Text = backUp[0];
            flightComboBox.Text = backUp[1];
            timePicker.Text = backUp[2];
            datePicker.Text = backUp[3];

            EndEditing();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {   
            EndEditing();
        }

        #endregion

        private void saveButton_Click_1(object sender, EventArgs e)
        {   
            Save(true);
        }

        private void flightsFilter_Leave(object sender, EventArgs e)
        {
            if (!flightsFilter.Items.Contains(flightsFilter.Text))
            {
                flightsFilter.Text = flightsFilter.Items[0].ToString();
            }
        }

        private void statusesFilter_Leave(object sender, EventArgs e)
        {
            if (!statusesFilter.Items.Contains(statusesFilter.Text))
            {
                statusesFilter.Text = statusesFilter.Items[0].ToString();
            }
        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
      
            this.statusesTableAdapter.Fill(this.airportDataSet.Statuses);
            this.flightsTableAdapter.Fill(this.airportDataSet.Flights);
            this.tableAdapter.Fill(this.airportDataSet.Journal);

            UpdateStatusesFilter();
            UpdateFlightsFilter();

            dataGridView_SelectionChanged(null, null);
        }

        private void startCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            startDatePicker.Enabled = (sender as CheckBox).Checked;
            Filter(null, null);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void endTextBox_CheckedChanged(object sender, EventArgs e)
        {
            endDatePicker.Enabled = (sender as CheckBox).Checked;
            Filter(null, null);
        }

        private void dataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введены некорректные данные.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            (sender as DataGridView).CancelEdit();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
