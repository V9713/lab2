using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddIncomeForm : Form
    {
        public Income NewIncome { get; private set; }

        public AddIncomeForm()
        {
            InitializeComponent();
            InitializeIncomeTypeComboBox();
        }

        private void InitializeIncomeTypeComboBox()
        {
            cmbIncomeType.Items.AddRange(new object[] { "Зарплата", "Дивиденды", "Аренда" });
            cmbIncomeType.SelectedIndex = 0;
        }

        private void cmbIncomeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSalary.Visible = cmbIncomeType.SelectedIndex == 0;
            panelDividend.Visible = cmbIncomeType.SelectedIndex == 1;
            panelRent.Visible = cmbIncomeType.SelectedIndex == 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (cmbIncomeType.SelectedIndex)
                {
                    case 0: // Salary
                        NewIncome = new Salary
                        {
                            Date = dtpSalaryDate.Value,
                            Sum = (int)nudSalarySum.Value
                        };
                        break;

                    case 1: // Dividend
                        NewIncome = new Dividend
                        {
                            Date = dtpDividendDate.Value,
                            AccountNumber = (int)nudDividendAccount.Value,
                            Sum = (int)nudDividendSum.Value
                        };
                        break;

                    case 2: // Rent
                        NewIncome = new Rent
                        {
                            Address = txtAddress.Text,
                            ObjectType = txtObjectType.Text,
                            Name = txtName.Text,
                            Sum = (int)nudRentSum.Value
                        };
                        break;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании дохода: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}