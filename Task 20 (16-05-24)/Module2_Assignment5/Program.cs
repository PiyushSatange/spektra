using Microsoft.EntityFrameworkCore;
using Module2_Assignment5.Models;

class Program
{
    public static void Main(string[] args)
    {
        var context = new PracticeContext();
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", "ID", "EmpName", "DeptName", "Salary");
        Console.WriteLine("-------------------------------------------------------------------------");
        context.SalaryViews.ToList().ForEach(e =>
        {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", e.EmpId, e.EmpName, e.DeptName, e.Salary);
        });
        Console.WriteLine("-------------------------------------------------------------------------");


        Console.WriteLine("Enter ID you want to update");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 : Update Name");
        Console.WriteLine("2 : Update Department");
        Console.WriteLine("3 : Update Salary");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("Enter new name");
                string name = Console.ReadLine();
                context.updateView("Emp_Name", name, id);
                break;
            case 2:
                Console.WriteLine("Enter new Department");
                string dept = Console.ReadLine();
                context.updateView("Dept_Name", dept, id);
            break;
            case 3:
                Console.WriteLine("Enter new Salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                context.updateView(salary, id);
            break;
            default:
                Console.WriteLine("Exiting...");
                break;
        }
            
        context.SaveChanges();

        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", "ID", "EmpName", "DeptName", "Salary");
        Console.WriteLine("-------------------------------------------------------------------------");
        context.SalaryViews.ToList().ForEach(e =>
        {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", e.EmpId, e.EmpName, e.DeptName, e.Salary);
        });
        Console.WriteLine("-------------------------------------------------------------------------");

    }
}