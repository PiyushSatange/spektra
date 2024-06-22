using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new practiceEntities();
            Console.WriteLine("Enter the department name : ");
            string dept = Console.ReadLine();
            var values = context.fn_getAllEmployee(dept);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("|{0,-10}|{1,-15}|{2,-15}|{3,-15}|","ID","Name","Department","Salary");
            Console.WriteLine("----------------------------------------------------");
            foreach( var value in values )
            {
                Console.WriteLine("|{0,-10}|{1,-15}|{2,-15}|{3,-15}|", value.emp_ID, value.emp_NAME, value.DEPT_NAME, value.SALARY);
            }
            Console.WriteLine("----------------------------------------------------");
            Console.ReadLine();
        }
    }
}
