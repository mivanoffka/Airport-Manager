using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrystalAirport.Forms
{
    public partial class FlightsForm : Form
    {
        public FlightsForm()
        {
            InitializeComponent();
        }

        private void HandleFormLoad(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter.Fill(this.airportDataSet.Journal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Journal". При необходимости она может быть перемещена или удалена.
            this.journalTableAdapter.Fill(this.airportDataSet.Journal);
            EndEditing();

            this.airlinesTableAdapter.Fill(this.airportDataSet.Airlines);
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);
            this.directionsTableAdapter.Fill(this.airportDataSet.Directions);
            this.directionsTableAdapter.Fill(this.airportDataSet.Directions);
            this.tableAdapter.Fill(this.airportDataSet.Flights);

            UpdateAirportFilter();
            UpdateDirectionsFilter();
            UpdateAirlinesFilter();

            dataGridView_SelectionChanged(null, null);
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

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            MessageBox.Show("Введены некорректные данные.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            (sender as DataGridView).CancelEdit();

        }

        #region Элементы управления

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
            row[2] = "[Новый рейс]";
            row[1] = 0;
            row[3] = 0;
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
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataRowView currentRow = bindingSource.Current as DataRowView;
            foreach (DataRow row in airportDataSet.Tables["Journal"].Rows)
            {   
                if (row.RowState != DataRowState.Deleted)
                {
                    if (row[1].ToString() == currentRow[0].ToString())
                    {
                        MessageBox.Show("Невозможно удалить этот рейс, поскольку на него ссылаются записи в «Журнале полётов»", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                row.Cells[1].Value = flightNameTextBox.Text;
            }

        }

        private void directionComboBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count <= 1)
            {
                return;
            }

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                row.Cells[2].Value = directionComboBox.Text;
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
                row.Cells[3].Value = airportComboBox.Text;
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
                row.Cells[4].Value = airlinesComboBox.Text;
            }
        }

        #endregion

        #region Фильтрация

        List<KeyValuePair<int, string>> airportsKeyValuePairs;
        List<KeyValuePair<int, string>> directionsKeyValuePairs;
        List<KeyValuePair<int, string>> airlinesKeyValuePairs;
        string anyKey = "(Не важно)";

        private void UpdateAirportFilter()
        {
            List<KeyValuePair<int, string>> keyValuePairs = new List<KeyValuePair<int, string>>();
            keyValuePairs.Add(new KeyValuePair<int, string>(-1, anyKey));
            foreach (DataRowView row in airportComboBox.Items)
            {
                keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(row[0]), Convert.ToString(row[1])));
            }

            airportsKeyValuePairs = keyValuePairs;
            var list = DictionaryHelper.GetValues(keyValuePairs);

            airportFilter.Items.Clear();
            foreach (string value in list)
            {
                airportFilter.Items.Add(value);
            }
            airportFilter.Text = anyKey;
        }

        private void UpdateDirectionsFilter()
        {
            List<KeyValuePair<int, string>> keyValuePairs = new List<KeyValuePair<int, string>>();
            keyValuePairs.Add(new KeyValuePair<int, string>(-1, anyKey));
            foreach (DataRowView row in directionComboBox.Items)
            {
                keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(row[0]), Convert.ToString(row[1])));
            }

            directionsKeyValuePairs = keyValuePairs;
            var list = DictionaryHelper.GetValues(keyValuePairs);
            directionFilter.Items.Clear();
            foreach (string value in list)
            {
                directionFilter.Items.Add(value);
            }
            directionFilter.Text = anyKey;
        }

        private void UpdateAirlinesFilter()
        {
            List<KeyValuePair<int, string>> keyValuePairs = new List<KeyValuePair<int, string>>();
            keyValuePairs.Add(new KeyValuePair<int, string>(-1, anyKey));
            foreach (DataRowView row in airlinesComboBox.Items)
            {
                keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(row[0]), Convert.ToString(row[1])));
            }

            airlinesKeyValuePairs = keyValuePairs;
            var list = DictionaryHelper.GetValues(keyValuePairs);
            airlinesFilter.Items.Clear();
            foreach (string value in list)
            {
                airlinesFilter.Items.Add(value);
            }
            airlinesFilter.Text = anyKey;
        }

        private void Filter(object sender, EventArgs e)
        {
            if (airportsKeyValuePairs == null || airlinesKeyValuePairs == null || directionsKeyValuePairs == null)
            {
                return;
            }
            dataGridView.Select();
            string rowFilter = "";
            string airportRowFilter = "";
            string airlinesRowFilter = "";
            string directionRowFilter = "";

            if (airportFilter.Text != anyKey)
            {
                int key = DictionaryHelper.GetKey(airportsKeyValuePairs, airportFilter.Text);
                airportRowFilter = "AirportID = " + key;
            }

            if (airlinesFilter.Text != anyKey)
            {
                int key = DictionaryHelper.GetKey(airlinesKeyValuePairs, airlinesFilter.Text);
                airlinesRowFilter = "AirlinesID = " + key;
            }

            if (directionFilter.Text != anyKey)
            {
                int key = DictionaryHelper.GetKey(directionsKeyValuePairs, directionFilter.Text);
                directionRowFilter = "DirectionID = " + key;
            }

            rowFilter += airportRowFilter;
            if (airlinesRowFilter != "")
                rowFilter += rowFilter == "" ? airlinesRowFilter : " and " + airlinesRowFilter;
            if (directionRowFilter != "")
                rowFilter += rowFilter == "" ? directionRowFilter : " and " + directionRowFilter;

            this.tableAdapter.Fill(this.airportDataSet.Flights);
            //MessageBox.Show(rowFilter);
            bindingSource.Filter = rowFilter;
            bindingSource.MoveFirst();

        }

        #endregion

        private void directionsLinkButton_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            DirectionsForm form = new DirectionsForm();
            form.ShowDialog(this);
            form.Dispose();
        }

        private void airportsLinkButton_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            if (airportDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения перед переходом к другой таблице? В противном случае все изменения будут потеряны", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            AirportsForm form = new AirportsForm();
            form.ShowDialog(this);
            form.Dispose();

            this.airportsTableAdapter.Fill(airportDataSet.Airports);
            UpdateAirportFilter();
        }

        private void airlinesLinkButton_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bindingSource.EndEdit();

            if (airportDataSet.HasChanges())
            {
                DialogResult result = MessageBox.Show("Хотите сохранить изменения перед переходом к другой таблице? В противном случае все изменения будут потеряны", "Вопрос", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Save();
                }
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            AirlinesForm form = new AirlinesForm();
            form.ShowDialog(this);
            form.Dispose();

            this.airlinesTableAdapter.Fill(airportDataSet.Airlines);
            UpdateAirlinesFilter();
        }

        private void ShowWarning()
        {
            MessageBox.Show("Прежде чем совершить данное действие, необходимо либо заполнить текущую запись корректными данными, либо удалить её.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        #region Правка записей

        string[] backUp;

        private void editButton_Click(object sender, EventArgs e)
        {
            StartEditing();
        }

        private void StartEditing()
        {
            backUp = new string[4] { directionComboBox.Text, airportComboBox.Text, flightNameTextBox.Text, airlinesLinkButton.Text };

            goNextButton.Enabled = false;
            goBackButton.Enabled = false;
            goFirstButton.Enabled = false;
            goLastButton.Enabled = false;
            addButton.Enabled = false;
            deleteButton.Enabled = false;
            directionsLinkButton.Enabled = false;
            airportsLinkButton.Enabled = false;
            airlinesLinkButton.Enabled = false;
            indexTextBox.Enabled = false;
            saveButton.Enabled = false;
            directionFilter.Enabled = false;
            airportFilter.Enabled = false;
            airlinesFilter.Enabled = false;
            rollbackButton.Enabled = false;

            directionComboBox.Enabled = true;
            airportComboBox.Enabled = true;
            flightNameTextBox.Enabled = true;
            airlinesComboBox.Enabled = true;

            dataGridView.DefaultCellStyle.ForeColor = Color.DarkGray;

            dataGridView.Enabled = false;

            declineButton.Visible = true;
            acceptButton.Visible = true;

            editButton.Visible = false;
        }

        private void EndEditing()
        {
            directionComboBox.Enabled = false;
            airportComboBox.Enabled = false;
            flightNameTextBox.Enabled = false;
            airlinesComboBox.Enabled = false;

            rollbackButton.Enabled = true;
            goNextButton.Enabled = true;
            goBackButton.Enabled = true;
            goFirstButton.Enabled = true;
            goLastButton.Enabled = true;
            addButton.Enabled = true;
            deleteButton.Enabled = true;
            directionsLinkButton.Enabled = true;
            airportsLinkButton.Enabled = true;
            airlinesLinkButton.Enabled = true;
            indexTextBox.Enabled = true;
            saveButton.Enabled = true;
            directionFilter.Enabled = true;
            airportFilter.Enabled = true;
            airlinesFilter.Enabled = true;

            dataGridView.Enabled = true;

            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

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
                ShowWarning();
            }
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            directionComboBox.Text = backUp[0];
            airportComboBox.Text = backUp[1];
            flightNameTextBox.Text = backUp[2];
            airlinesLinkButton.Text = backUp[3];

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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rollbackButton_Click(object sender, EventArgs e)
        {
            this.directionsTableAdapter.Fill(this.airportDataSet.Directions);
            this.airlinesTableAdapter.Fill(this.airportDataSet.Airlines);
            this.airportsTableAdapter.Fill(this.airportDataSet.Airports);
            this.tableAdapter.Fill(this.airportDataSet.Flights);

            UpdateAirlinesFilter();
            UpdateAirportFilter();
            UpdateDirectionsFilter();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void directionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void airportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void airlinesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
