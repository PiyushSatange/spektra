using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new practiceEntities();
            var values = context.fn_getAllTables();
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("|{0,-10}|{1,-15}|{2,-20}|{3,-15}|", "ID", "FirstName", "DeptName", "Salary");
            Console.WriteLine("-----------------------------------------------------------------------");
            foreach( var value in values )
            {
                Console.WriteLine("|{0,-10}|{1,-15}|{2,-20}|{3,-15}|", value.id, value.first_name, value.dept_name, value.salary);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
