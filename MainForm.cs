using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private const string DataFile = "incomes.txt";
        private List<Income> incomes = new List<Income>();

        public MainForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadData();
        }

        private void InitializeDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Тип",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Date",
                HeaderText = "Дата",
                Width = 100
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Details",
                HeaderText = "Детали",
                Width = 200
            });

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sum",
                HeaderText = "Сумма",
                Width = 80
            });
        }

        private void LoadData()
        {
            try
            {
                incomes = FileManager.ReadIncomesFromFile(DataFile);

                var displayList = new List<IncomeDisplay>();
                foreach (var income in incomes)
                {
                    displayList.Add(new IncomeDisplay(income));
                }

                dataGridView.DataSource = null;
                dataGridView.DataSource = displayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            try
            {
                FileManager.SaveIncomesToFile(DataFile, incomes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddIncomeForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK && addForm.NewIncome != null)
                {
                    incomes.Add(addForm.NewIncome);
                    SaveData();
                    LoadData(); // Обновляем данные
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < incomes.Count)
                {
                    incomes.RemoveAt(selectedIndex);
                    SaveData();
                    LoadData(); // Обновляем данные
                }
            }
        }

        private void btnOpenCommands_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExecuteCommands(openFileDialog.FileName);
                    SaveData();
                    LoadData(); // Обновляем данные
                }
            }
        }
        

        private void ExecuteCommands(string commandFile)
        {
            try
            {
                string[] commands = File.ReadAllLines(commandFile);
                foreach (string cmd in commands)
                {
                    if (string.IsNullOrWhiteSpace(cmd)) continue;

                    string[] parts = cmd.Split(new[] { ' ' }, 2);
                    if (parts.Length != 2) continue;

                    string command = parts[0].ToUpper();
                    string args = parts[1].Trim();

                    switch (command)
                    {
                        case "ADD":
                            Income newIncome = FileManager.CreateIncomeFromString(args);
                            if (newIncome != null)
                                incomes.Add(newIncome);
                            break;

                        case "REM":
                            incomes.RemoveAll(i => i.MatchesCondition(args));
                            break;

                        case "SAVE":
                            FileManager.SaveIncomesToFile(args, incomes);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения команд: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }

    public class IncomeDisplay
    {
        public string Type { get; set; }
        public string Date { get; set; }
        public string Details { get; set; }
        public int Sum { get; set; }

        public IncomeDisplay(Income income)
        {
            Sum = income.Sum;

            switch (income)
            {
                case Salary salary:
                    Type = "Зарплата";
                    Date = salary.Date.ToString("dd.MM.yyyy");
                    Details = "";
                    break;

                case Dividend dividend:
                    Type = "Дивиденды";
                    Date = dividend.Date.ToString("dd.MM.yyyy");
                    Details = $"Счет: {dividend.AccountNumber}";
                    break;

                case Rent rent:
                    Type = "Аренда";
                    Date = "";
                    Details = $"{rent.Address}, {rent.ObjectType}, {rent.Name}";
                    break;
            }
        }
    }
}