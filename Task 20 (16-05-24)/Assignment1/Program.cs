using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new practiceEntities();

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("|{0,-8}|{1,-15}|{2,-15}|{3,-15}|", "ID", "Emp Name", "Dept Name", "Salary");
            Console.WriteLine("----------------------------------------------------------");
            context.employees.ToList().ForEach(e =>
            {
                Console.WriteLine("|{0,-8}|{1,-15}|{2,-15}|{3,-15}|", e.emp_ID,e.emp_NAME,e.DEPT_NAME,e.SALARY);
            });
            Console.WriteLine("----------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
