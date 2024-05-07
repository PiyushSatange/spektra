using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Employee
    {
        public int monthlySales;
        public int baseSalary;
        public Employee(int monthlySales, int baseSalary)
        {
            this.monthlySales = monthlySales;
            this.baseSalary = baseSalary;
        }
        public Employee() { }
    }
    class SalesAssociate : Employee
    {
        public SalesAssociate( int monthlySales,  int baseSalary) : base(monthlySales, baseSalary) {

        }
        public void numberOfSales(int sales)
        {
            monthlySales = sales;
        }
        public double salesBonus()
        {
            if (monthlySales > 30)
            {
                return baseSalary * 0.20;
            }
            else if (monthlySales > 20)
            {
                return baseSalary * 0.10;
            }
            else if (monthlySales > 10)
            {
                return baseSalary * 0.05;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SalesAssociate sa = new SalesAssociate(11, 10000);
            Console.WriteLine($"Sales done by the employee is {sa.monthlySales}");
            Console.WriteLine($"Basic pay of the employee is {sa.baseSalary} rs");
            Console.WriteLine($"Bonus allocated is {sa.salesBonus()} rs");
            Console.ReadKey();
        }
    }
}
