using System;

namespace Lab2
{
    public abstract class Income
    {
        public int Sum { get; set; }

        public abstract void ReadFromString(string data);
        public abstract override string ToString();
    }

    public class Salary : Income
    {
        public DateTime Date { get; set; }

        public override void ReadFromString(string data)
        {
            string[] parts = data.Split(' ');
            Date = DateTime.Parse(parts[1]);
            Sum = int.Parse(parts[2]);
        }

        public override string ToString()
        {
            return $"Зарплата {Date:yyyy-MM-dd} {Sum}";
        }
    }

    public class Dividend : Income
    {
        public int AccountNumber { get; set; }
        public DateTime Date { get; set; }

        public override void ReadFromString(string data)
        {
            string[] parts = data.Split(' ');
            Date = DateTime.Parse(parts[1]);
            AccountNumber = int.Parse(parts[2]);
            Sum = int.Parse(parts[3]);
        }

        public override string ToString()
        {
            return $"Дивиденды {Date:yyyy-MM-dd} {AccountNumber} {Sum}";
        }
    }

    public class Rent : Income
    {
        public string Address { get; set; }
        public string ObjectType { get; set; }
        public string Name { get; set; }

        public override void ReadFromString(string data)
        {
            string[] parts = data.Split(' ');
            Address = parts[1];
            ObjectType = parts[2];
            Name = parts[3];
            Sum = int.Parse(parts[4]);
        }

        public override string ToString()
        {
            return $"Аренда {Address} {ObjectType} {Name} {Sum}";
        }
    }
}