using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new practiceEntities();
            var employees = context.employeeDetails();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("|{0,-10}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|","ID","Name","Department","Salary","Designation");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach(var employee in employees)
            {
                Console.WriteLine("|{0,-10}|{1,-15}|{2,-15}|{3,-15}|{4,-15}|", employee.emp_ID, employee.emp_NAME, employee.DEPT_NAME, employee.SALARY, employee.designation);
            }
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
