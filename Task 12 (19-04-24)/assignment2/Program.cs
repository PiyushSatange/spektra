using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 3, 5, 7, 9 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            int[] arr3 = arr1.Concat(arr2).ToArray(); 
            Array.Sort(arr3);
            foreach(int i in arr3)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
