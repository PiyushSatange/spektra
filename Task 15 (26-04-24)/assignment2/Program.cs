using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public delegate double operationDeligate(double a, double b);

    internal class Program
    {
        public static double addition(double a, double b)
        {
            return a + b;
        }
        public static double subtraction(double a, double b)
        {
            return a - b;
        }
        public static double multiplication(double a, double b)
        {
            return a * b;
        }
        public static double division(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            operationDeligate operation = new operationDeligate(addition);
            Console.WriteLine($"Addition : {operation.Invoke(2, 4)}");
            operation += subtraction;
            Console.WriteLine($"Subtraction : {operation.Invoke(2, 4)}");
            operation += multiplication;
            Console.WriteLine($"Multiplication : {operation.Invoke(2, 4)}"); 
            operation += division;
            Console.WriteLine($"Division : {operation.Invoke(2, 4)}");
            Console.ReadKey();
        }
    }
}
