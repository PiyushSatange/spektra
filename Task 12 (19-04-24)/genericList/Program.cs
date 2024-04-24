using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(11);
            list.Add(22);
            list.Add(33);
            list.Add(44);
            list.Add(55);

            Console.WriteLine("Using for loop");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Using foreach loop");
            foreach (int num in list)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();

            Console.WriteLine("Using indexes");
            Console.WriteLine($"value at index 2 = {list[2]}");

            Console.ReadKey();
        }
    }
}
