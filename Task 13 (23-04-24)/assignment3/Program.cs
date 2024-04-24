using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public Employee(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"ID:{this.id}\nName:{this.name}\nSalary:{this.salary}\n=========================";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(101, "Piyush", 7000));
            empList.Add(new Employee(102, "Yash", 9000));
            empList.Add(new Employee(103, "Abhinav", 8000));
            empList.Add(new Employee(104, "Zoe", 6000));
            empList.Add(new Employee(105, "Lia", 4000));
            empList.Add(new Employee(106, "Deep", 3000));

            var employees = empList.Where(e => e.name.Length < 4);

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
        }
    }
}
