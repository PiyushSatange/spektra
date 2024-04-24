using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any string : ");
            string str = Console.ReadLine();
            Regex rx = new Regex("[^a-zA-Z0-9-_]");
            string ans = rx.Replace(str, "");
            Console.WriteLine($"String after removing removing special character : {ans}");
            Console.ReadKey();
        }
    }
}
