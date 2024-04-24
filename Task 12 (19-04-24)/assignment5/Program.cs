using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x coordinate : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y coordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            if(x > 0 && y > 0)
            {
                Console.WriteLine("Coordinate point lies in quadrant 1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Coordinate point lies in quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Coordinate point lies in quadrant 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Coordinate point lies in quadrant 4");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Coordinate point lies on the origin");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Coordinate point lies on y axis");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("Coordinate point lies on x axis");
            }
            Console.ReadKey();
        }
    }
}
