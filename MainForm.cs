using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private const string FilePath = "incomes.txt";
        private List<Income> _incomes;

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadIncomes();
        }

        private void InitializeDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Тип",
                DataPropertyName = "Type",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Дата",
                DataPropertyName = "Date",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Детали",
                DataPropertyName = "Details",
                Width = 200
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Сумма",
                DataPropertyName = "Sum",
                Width = 80
            });
        }

        private void LoadIncomes()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    File.Create(FilePath).Close();
                }

                _incomes = FileManager.ReadIncomesFromFile(FilePath);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            var displayList = new List<IncomeDisplay>();

            foreach (var income in _incomes)
            {
                displayList.Add(new IncomeDisplay(income));
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = displayList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddIncomeForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    _incomes.Add(addForm.NewIncome);
                    FileManager.SaveIncomesToFile(FilePath, _incomes);
                    RefreshDataGridView();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedIndex = dataGridView.SelectedRows[0].Index;
            _incomes.RemoveAt(selectedIndex);
            FileManager.SaveIncomesToFile(FilePath, _incomes);
            RefreshDataGridView();
        }
    }

    public class IncomeDisplay
    {
        public string Type { get; }
        public string Date { get; }
        public string Details { get; }
        public int Sum { get; }

        public IncomeDisplay(Income income)
        {
            Sum = income.Sum;

            switch (income)
            {
                case Salary salary:
                    Type = "Зарплата";
                    Date = salary.Date.ToString("yyyy-MM-dd");
                    Details = string.Empty;
                    break;

                case Dividend dividend:
                    Type = "Дивиденды";
                    Date = dividend.Date.ToString("yyyy-MM-dd");
                    Details = $"Счет: {dividend.AccountNumber}";
                    break;

                case Rent rent:
                    Type = "Аренда";
                    Date = string.Empty;
                    Details = $"{rent.Address}, {rent.ObjectType}, {rent.Name}";
                    break;
            }
        }
    }
}