using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee
{
    class Employee
    {
        private int empId;
        private string empName;
        private string empDesignation;
        private int empSalary;

        public int Id
        {
            get { return empId; }
            set { empId = value; }
        }
        public string Name
        {
            get { return empName; }
            set { empName = value; }
        }
        public string Designation
        {
            get { return empDesignation; }
            set { empDesignation = value; }
        }
        public int Salary
        {
            get { return empSalary; }
            set { empSalary = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Piyush";
            e.Designation = "Developer";
            e.Salary = 300000;
            Console.WriteLine("ID : "+e.Id + "\nName : " + e.Name + "\nDesignation : " + e.Designation + "\nSalary : " + e.Salary);
            Console.ReadKey();
        }
    }
}
