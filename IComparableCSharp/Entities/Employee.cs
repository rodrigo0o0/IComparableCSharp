using System;
using System.Globalization;


namespace IComparableCSharp.Entities
{
    internal class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string employe)
        {
            string [] vect = employe.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1],CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + " R$ " + Salary.ToString("F2",CultureInfo.InvariantCulture) + " reais";
        }

        public int CompareTo(object obj)
        {
            if(obj != null)
            {
                Employee other = (Employee)obj;
                return Salary.CompareTo(other.Salary);
            }
            else
            {
                throw new ArgumentException("Objeto nulo no CompareTo.");
            }
        }
    }
}
