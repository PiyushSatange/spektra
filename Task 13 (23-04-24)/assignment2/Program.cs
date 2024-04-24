using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
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
            empList.Add(new Employee(104, "Mayru", 6000));
            empList.Add(new Employee(105, "Shreyash", 4000));
            empList.Add(new Employee(106, "Deep", 3000));

            var employee = empList.Where(e => (e.salary >= 600 && e.salary <= 8000));

            foreach(Employee emp in employee)
            {
                Console.WriteLine(emp);
            }
            Console.ReadKey();
        }
    }
}
