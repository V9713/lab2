using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    public static class FileManager
    {
        public static List<Income> ReadIncomesFromFile(string filePath)
        {
            List<Income> incomes = new List<Income>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(' ');
                Income income = CreateIncome(data[0]);

                if (income != null)
                {
                    income.ReadFromString(line);
                    incomes.Add(income);
                }
            }

            return incomes;
        }

        public static void SaveIncomesToFile(string filePath, List<Income> incomes)
        {
            List<string> lines = new List<string>();
            foreach (var income in incomes)
            {
                lines.Add(income.ToString());
            }
            File.WriteAllLines(filePath, lines);
        }

        private static Income CreateIncome(string incomeType)
        {
            switch (incomeType)
            {
                case "Зарплата": return new Salary();
                case "Дивиденды": return new Dividend();
                case "Аренда": return new Rent();
                default:
                    Console.WriteLine($"Неизвестный тип дохода: {incomeType}");
                    return null;
            }
        }
    }
}