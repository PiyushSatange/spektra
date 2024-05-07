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
            List<int> intList = new List<int>() { 1,2,3,4,5};
            List<string> stringList = new List<string>() { "Piyush", "Yash", "Atharv", "Nitesh"};

            Action<List<int>> intAction = printItems;
            intAction.Invoke(intList);

            Action<List<string>> stringAction = printItems;
            stringAction.Invoke(stringList);


            void printItems<T>(List<T> list)
            {

                foreach(T item in list)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
