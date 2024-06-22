using Assignment3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography;

namespace program
{
    class Assignment
    {
        
        public void addData(int eId, string eName, string dName, int money)
        {
            var context = new PracticeContext();
            Employee employee = new Employee
            {
                EmpId = eId,
                EmpName = eName,
                DeptName = dName,
                Salary = money
            };
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void getData(int id) 
        {
            var context = new PracticeContext();
            Employee e = context.Employees.Find(id);
            
            if(e != null)
            {
                Console.WriteLine("---------------------------------------------------------------------------");
                Console.WriteLine("|{0,10}|{1,20}|{2,20}|{3,20}|", "EmpId", "EmpName", "DeptName", "DeptName");
                Console.WriteLine("---------------------------------------------------------------------------");

                Console.WriteLine("|{0,10}|{1,20}|{2,20}|{3,20}|",e.EmpId, e.EmpName, e.DeptName, e.Salary);
                Console.WriteLine("---------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"No data is present for id {id}");
            }
        }

        public void getAllData()
        {
            var context = new PracticeContext();
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", "EmpId", "EmpName", "DeptName", "DeptName");
            Console.WriteLine("---------------------------------------------------------------------------");
            context.Employees.ToList().ForEach(e => 
            {
                Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", e.EmpId, e.EmpName, e.DeptName, e.DeptName);

            });
            Console.WriteLine("---------------------------------------------------------------------------");
        }

        public void removeData(int eid)
        {
            var context = new PracticeContext();
            Employee e = context.Employees.Find(eid);
            if (e != null)
            {
                context.Employees.Remove(e);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No data is present with this id {eid}");
            }
        }

        private void updateData(int id, string empname, string deptname, int salary)
        {
            var context = new PracticeContext();
            Employee e = context.Employees.Find(id);
            if(e!=null)
            {
                e.EmpName = empname;
                e.DeptName = deptname;
                e.Salary = salary;
            }
            context.Entry(e).State = EntityState.Modified;
            context.SaveChanges();
            Console.WriteLine("Data Updated Successfully");
        }
        public static void Main(string[] args)
        {
            Assignment assignment = new Assignment();
            int n;
            do
            {
                Console.WriteLine("Enter the No : ");
                Console.WriteLine("Enter 1 to add the data");
                Console.WriteLine("Enter 2 to retrive the row");
                Console.WriteLine("Enter 3 to retrive all the data");
                Console.WriteLine("Enter 4 to update the data");
                Console.WriteLine("Enter 5 to delete the data");
                Console.WriteLine("Enter 6 to exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Enter the id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the emp name: ");
                        string empName = Console.ReadLine();
                        Console.WriteLine("Enter the dept name: ");
                        string deptName = Console.ReadLine();
                        Console.WriteLine("Enter the salary: ");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        assignment.addData(id, empName, deptName, salary);
                        break;
                    case 2:
                        Console.WriteLine("Enter the id: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        assignment.getData(id1);
                        break;
                    case 3:
                        assignment.getAllData();
                        break;
                    case 4:
                        Console.WriteLine("Enter the id: ");
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the emp name: ");
                        string empName1 = Console.ReadLine();
                        Console.WriteLine("Enter the dept name: ");
                        string deptName2 = Console.ReadLine();
                        Console.WriteLine("Enter the salary: ");
                        int salary1 = Convert.ToInt32(Console.ReadLine());
                        assignment.updateData(id3, empName1, deptName2, salary1);
                        break;
                    case 5:
                        Console.WriteLine("Enter the id: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        assignment.removeData(id2);
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid number pressed");
                        break;
                }
            } while (n != 6);
        }

        
    }
}