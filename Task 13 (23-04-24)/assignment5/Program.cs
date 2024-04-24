using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    internal class Program
    {
        static long factorial(int no)
        {
            if (no == 1)
                return 1;
            return no * factorial(no - 1);
            
        }

        static int fibonacci(int no)
        {
            if (no == 0 || no == 1)
                return no;

            return fibonacci(no - 1) + fibonacci(no - 2);
        }

 
        static async Task Main(string[] args)
        {
            int ans1 = await Task.Run(() => (fibonacci(20)));
            long ans2 = await Task.Run(() => (factorial(20)));
            Console.WriteLine($"20th Fabonacci No : {ans1}");
            Console.WriteLine($"Factorial of 20 : {ans2}");
            Console.ReadKey();
        }
    }
}
