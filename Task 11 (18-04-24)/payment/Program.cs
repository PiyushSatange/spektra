using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payment
{
    class Pay
    {
        private int amount;

        public Pay(int amount)
        {
            this.amount = amount;
        }
        public void doPayment()
        {
            Console.WriteLine(this.amount + " rs has been sent by UPI");
        }
        public void doPayment(int accNo)
        {
            Console.WriteLine(this.amount + " rs has been sent by Bank Transfer");
        }
        public void doPayment(int cardNo, int code)
        {
            Console.WriteLine(this.amount + " rs has been sent by Credit Card");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pay p = new Pay(10);
            p.doPayment();
            Console.ReadKey();
        }
    }
}
