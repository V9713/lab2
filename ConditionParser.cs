// ConditionParser.cs
using System;

namespace Lab2
{
    public static class ConditionParser
    {
        public static bool CheckCondition(string condition, int sum, DateTime date)
        {
            // Парсинг условий для числовых полей и даты
            if (condition.Contains("sum"))
            {
                return CompareNumbers(sum, condition.Replace("sum", "").Trim());
            }
            else if (condition.Contains("date"))
            {
                return CompareDates(date, condition.Replace("date", "").Trim());
            }
            return false;
        }

        private static bool CompareNumbers(int value, string condition)
        {
            // Реализация проверки условий для чисел
            if (condition.Contains("<=")) return value <= int.Parse(condition.Split("<=")[1].Trim());
            if (condition.Contains(">=")) return value >= int.Parse(condition.Split(">=")[1].Trim());
            if (condition.Contains("<")) return value < int.Parse(condition.Split('<')[1].Trim());
            if (condition.Contains(">")) return value > int.Parse(condition.Split('>')[1].Trim());
            if (condition.Contains("=")) return value == int.Parse(condition.Split('=')[1].Trim());
            return false;
        }

        private static bool CompareDates(DateTime date, string condition)
        {
            // Реализация проверки условий для дат
            var dateStr = condition.Split(new[] { '<', '>', '=' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
            var compareDate = DateTime.Parse(dateStr);

            if (condition.Contains("<=")) return date <= compareDate;
            if (condition.Contains(">=")) return date >= compareDate;
            if (condition.Contains("<")) return date < compareDate;
            if (condition.Contains(">")) return date > compareDate;
            if (condition.Contains("=")) return date == compareDate;
            return false;
        }
    }
}