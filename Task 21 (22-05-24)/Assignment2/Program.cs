using Assignment2.Models;

class Program
{
    public static void Main(string[] args)
    {
        int n;
        var context = new OfficeContext();

        do
        {
            Console.WriteLine("Press 1 : Get all employees");
            Console.WriteLine("Press 2 : Get employee by id");
            Console.WriteLine("Press 3 : Add employee");
            Console.WriteLine("Press 4 : Update employee");
            Console.WriteLine("Press 5 : To Exit");
            n = Convert.ToInt32(Console.ReadLine());

            switch(n)
            {
                case 1:
                    context.getAllEmployees();
                    break;
                case 2:
                    Console.WriteLine("Enter the id of employee");
                    int id = Convert.ToInt32(Console.ReadLine());
                    context.getEmployeeById(id);
                    break;
                case 3:
                    Console.WriteLine("Enter first name");
                    string firstname = Console.ReadLine();

                    Console.WriteLine("Enter last name");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter designation");
                    string desig = Console.ReadLine();

                    Console.WriteLine("Enter salary");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter phone number");
                    string phoneNo = Console.ReadLine();

                    Employee e = new Employee();
                    e.FirstName = firstname;
                    e.LastName = lastname;
                    e.PhoneNumber = phoneNo;
                    e.Salary = salary;
                    e.Designation = desig;

                    context.addEmployee(e);
                    break;
                case 4:
                    context.update();
                    break;
                case 5:
                    Console.WriteLine("Exiting");
                    break;
                default:
                    Console.WriteLine("Enter valid value");
                    break;
            }

        } while (n != 5);
        //context.getAllEmployees();
        //Console.ReadKey();
        //context.getEmployeeById(1);
        //Employee e = new Employee();
        //e.FirstName = "Piyush";
        //e.LastName = "Satange";
        //e.Salary = 4000;
        //e.PhoneNumber = "9607772094";
        //e.Designation = "Intern";
        //context.addEmployee(e);
        //context.update();
    }
}