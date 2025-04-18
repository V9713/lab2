using System;

namespace Lab2
{
    public abstract class Income
    {
        public int Sum { get; set; }
        public abstract void ReadFromString(string data);
        public abstract bool MatchesCondition(string condition);
        public abstract override string ToString();
    }

    public class Salary : Income
    {
        public DateTime Date { get; set; }

        public override void ReadFromString(string data)
        {
            var parts = data.Split(';');
            Date = DateTime.Parse(parts[1].Trim());
            Sum = int.Parse(parts[2].Trim());
        }

        public override bool MatchesCondition(string condition)
        {
            if (condition.Contains("sum"))
            {
                string valuePart = condition.Replace("sum", "").Trim();
                return CompareNumber(Sum, valuePart);
            }
            if (condition.Contains("date"))
            {
                string valuePart = condition.Replace("date", "").Trim();
                return CompareDate(Date, valuePart);
            }
            return false;
        }

        private bool CompareNumber(int value, string condition)
        {
            if (condition.Contains("<="))
                return value <= int.Parse(condition.Replace("<=", "").Trim());
            if (condition.Contains(">="))
                return value >= int.Parse(condition.Replace(">=", "").Trim());
            if (condition.Contains("<"))
                return value < int.Parse(condition.Replace("<", "").Trim());
            if (condition.Contains(">"))
                return value > int.Parse(condition.Replace(">", "").Trim());
            if (condition.Contains("="))
                return value == int.Parse(condition.Replace("=", "").Trim());
            return false;
        }

        private bool CompareDate(DateTime date, string condition)
        {
            DateTime compareDate = DateTime.Parse(condition.Substring(1).Trim());
            switch (condition[0])
            {
                case '<': return date < compareDate;
                case '>': return date > compareDate;
                case '=': return date == compareDate;
                default: return false;
            }
        }

        public override string ToString() => $"Salary;{Date:dd.MM.yyyy};{Sum}";
    }

    public class Dividend : Income
    {
        public DateTime Date { get; set; }
        public int AccountNumber { get; set; }

        public override void ReadFromString(string data)
        {
            var parts = data.Split(';');
            Date = DateTime.Parse(parts[1].Trim());
            AccountNumber = int.Parse(parts[2].Trim());
            Sum = int.Parse(parts[3].Trim());
        }

        public override bool MatchesCondition(string condition)
        {
            if (condition.Contains("sum"))
            {
                string valuePart = condition.Replace("sum", "").Trim();
                return CompareNumber(Sum, valuePart);
            }
            if (condition.Contains("date"))
            {
                string valuePart = condition.Replace("date", "").Trim();
                return CompareDate(Date, valuePart);
            }
            if (condition.Contains("account"))
            {
                string valuePart = condition.Replace("account", "").Trim();
                return CompareNumber(AccountNumber, valuePart);
            }
            return false;
        }

        private bool CompareNumber(int value, string condition)
        {
            if (condition.Contains("<="))
                return value <= int.Parse(condition.Replace("<=", "").Trim());
            if (condition.Contains(">="))
                return value >= int.Parse(condition.Replace(">=", "").Trim());
            if (condition.Contains("<"))
                return value < int.Parse(condition.Replace("<", "").Trim());
            if (condition.Contains(">"))
                return value > int.Parse(condition.Replace(">", "").Trim());
            if (condition.Contains("="))
                return value == int.Parse(condition.Replace("=", "").Trim());
            return false;
        }

        private bool CompareDate(DateTime date, string condition)
        {
            DateTime compareDate = DateTime.Parse(condition.Substring(1).Trim());
            switch (condition[0])
            {
                case '<': return date < compareDate;
                case '>': return date > compareDate;
                case '=': return date == compareDate;
                default: return false;
            }
        }

        public override string ToString() => $"Dividend;{Date:dd.MM.yyyy};{AccountNumber};{Sum}";
    }

    public class Rent : Income
    {
        public string Address { get; set; }
        public string ObjectType { get; set; }
        public string Name { get; set; }

        public override void ReadFromString(string data)
        {
            var parts = data.Split(';');
            Address = parts[1].Trim();
            ObjectType = parts[2].Trim();
            Name = parts[3].Trim();
            Sum = int.Parse(parts[4].Trim());
        }

        public override bool MatchesCondition(string condition)
        {
            if (condition.Contains("sum"))
            {
                string valuePart = condition.Replace("sum", "").Trim();
                return CompareNumber(Sum, valuePart);
            }
            if (condition.Contains("address"))
            {
                string valuePart = condition.Replace("address", "").Trim();
                return CompareString(Address, valuePart);
            }
            if (condition.Contains("type"))
            {
                string valuePart = condition.Replace("type", "").Trim();
                return CompareString(ObjectType, valuePart);
            }
            if (condition.Contains("name"))
            {
                string valuePart = condition.Replace("name", "").Trim();
                return CompareString(Name, valuePart);
            }
            return false;
        }

        private bool CompareNumber(int value, string condition)
        {
            if (condition.Contains("<="))
                return value <= int.Parse(condition.Replace("<=", "").Trim());
            if (condition.Contains(">="))
                return value >= int.Parse(condition.Replace(">=", "").Trim());
            if (condition.Contains("<"))
                return value < int.Parse(condition.Replace("<", "").Trim());
            if (condition.Contains(">"))
                return value > int.Parse(condition.Replace(">", "").Trim());
            if (condition.Contains("="))
                return value == int.Parse(condition.Replace("=", "").Trim());
            return false;
        }

        private bool CompareString(string value, string condition)
        {
            if (condition.StartsWith("="))
            {
                string compareTo = condition.Substring(1).Trim().Trim('"');
                return value.Equals(compareTo, StringComparison.OrdinalIgnoreCase);
            }
            if (condition.StartsWith("!="))
            {
                string compareTo = condition.Substring(2).Trim().Trim('"');
                return !value.Equals(compareTo, StringComparison.OrdinalIgnoreCase);
            }
            if (condition.StartsWith("contains "))
            {
                string compareTo = condition.Substring(8).Trim().Trim('"');
                return value.IndexOf(compareTo, StringComparison.OrdinalIgnoreCase) >= 0;
            }
            return false;
        }

        public override string ToString() => $"Rent;{Address};{ObjectType};{Name};{Sum}";
    }
}