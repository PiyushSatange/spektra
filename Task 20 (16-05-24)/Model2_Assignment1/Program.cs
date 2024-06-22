using Microsoft.EntityFrameworkCore;
using Model2_Assignment1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        var context = new PracticeContext();
        Console.WriteLine("---------------------------------------------------------------------------");
        Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|", "ID", "Dept", "Name", "Salary");
        Console.WriteLine("---------------------------------------------------------------------------");
        context.getEmployeeGreaterThan(5000).ForEach(e =>
        {
            Console.WriteLine("|{0,-10}|{1,-20}|{2,-20}|{3,-20}|" ,e.emp_ID,e.DEPT_NAME,e.emp_NAME,e.SALARY);
        });
        Console.WriteLine("---------------------------------------------------------------------------");

    }
}
