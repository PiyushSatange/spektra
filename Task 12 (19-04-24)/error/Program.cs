using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace error
{
    class TemperatureException : Exception
    {

        public TemperatureException(string msg) : base(msg) { }
        public TemperatureException() : base() { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature : ");
            int temp = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (temp <= 0)
                {
                    throw new TemperatureException("Temperature has gone below 0");
                }
            }
            catch(TemperatureException t)
            {
                Console.WriteLine(t);
            }
            finally
            {
                Console.WriteLine("Code Ended");
            }

            Console.ReadKey();
        }
    }
}
