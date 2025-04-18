using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    public static class FileManager
    {
        public static List<Income> ReadIncomesFromFile(string path)
        {
            var list = new List<Income>();
            if (!File.Exists(path)) return list;

            foreach (var line in File.ReadAllLines(path))
            {
                var income = CreateIncomeFromString(line);
                if (income != null) list.Add(income);
            }
            return list;
        }

        public static Income CreateIncomeFromString(string data)
        {
            if (string.IsNullOrWhiteSpace(data)) return null;

            var parts = data.Split(';');
            if (parts.Length < 1) return null;

            var type = parts[0].Trim();
            Income income = null;

            switch (type)
            {
                case "Salary":
                    income = new Salary();
                    break;
                case "Dividend":
                    income = new Dividend();
                    break;
                case "Rent":
                    income = new Rent();
                    break;
            }

            income?.ReadFromString(data);
            return income;
        }

        public static void SaveIncomesToFile(string path, List<Income> incomes)
        {
            var lines = new List<string>();
            foreach (var income in incomes)
            {
                lines.Add(income.ToString());
            }
            File.WriteAllLines(path, lines);
        }
    }
}