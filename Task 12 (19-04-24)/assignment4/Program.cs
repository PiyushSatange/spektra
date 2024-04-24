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
            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine($"Enter {n} numbers");
            for(int i=0; i<n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            List<int> odd = new List<int>();
            List<int> even = new List<int>();
            foreach(int i in arr)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            int[] oddArray = odd.ToArray();
            int[] evenArray = even.ToArray();

            Console.Write("Odd Array is : ");
            foreach(int i in oddArray)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Even Array is : ");
            foreach (int i in evenArray)
            {
                Console.Write($"{i} ");
            }

            Console.ReadKey();
        }
    }
}
