using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Enter the count of number you want to enter : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                Console.Write($"Member {i} : ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("Enter the specific value : ");
            int value = Convert.ToInt32(Console.ReadLine());
            var moreThanList = list.Where(e => e > value);
            Console.WriteLine("The numbers are : ");
            foreach(int i in moreThanList)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
