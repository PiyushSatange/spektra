using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
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

            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach(int i in arr)
            {
                if (freq.ContainsKey(i))
                {
                    freq[i]++;
                }
                else
                {
                    freq.Add(i, 1);
                }
            }
            Console.WriteLine("Frequency of elements are : ");
            foreach (KeyValuePair<int, int> f in freq)
            {
                Console.WriteLine($"{f.Key} => {f.Value}");
            }
            Console.ReadKey();
        }
    }
}
