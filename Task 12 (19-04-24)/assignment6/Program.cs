using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no of Units consumed : ");
            int units = Convert.ToInt32(Console.ReadLine());
            int rateBelow100 = 5;
            int rateBelow200 = 10;
            int rateAbove200 = 15;
            Console.WriteLine("=========================Bill Recipt==========================");
            Console.WriteLine($"Name of Costumer : {name}");
            Console.WriteLine($"ID of Costumer : {id}");
            Console.WriteLine($"No of units Consumed : {units}");
            if (units >= 0 && units <= 100)
            {
                Console.WriteLine($"Amount to be paid : {units * rateBelow100}");
            }
            else if(units >= 101 && units <= 200)
            {
                Console.WriteLine($"Amount to be paid : {units * rateBelow200}");
            }
            else
            {
                Console.WriteLine($"Amount to be paid : {units * rateAbove200}");
            }
            Console.ReadKey();
        }
    }
}
