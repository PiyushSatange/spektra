using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    class PersonBankAccnt
    {
        public static string name;
        public const int minBalance = 1000;
        public const int rateOfInterest = 7;
        public const int periodicity = 6;
        public int balance;

        static PersonBankAccnt()
        {
            Console.Write("Enter the name of Bank : ");
            name = Console.ReadLine();
            Console.WriteLine($"{name} bank has been created successfylly");
        }

        public static void renameBank()
        {
            Console.Write("Enter the Name : ");
            string value = Console.ReadLine();
            name = value;
            Console.WriteLine($"Bank name has been changed successfylly to {name}");
        }

        public int withdraw()
        {
            Console.Write("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if ((balance - amount) >= minBalance)
            {
                balance -= amount;
                Console.WriteLine($"Amount of {amount}$ has been withdraw successfylly and available balance is {balance}$");
                return amount;
            }
            else
            {
                Console.WriteLine("Sorry! Your transaction can not be processed due to low balance");
                return 0;
            } 
        }

        public void Deposite()
        {
            Console.Write("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            balance += amount;
            Console.WriteLine($"Amount of {amount}$ has been deposited and your total balance is {balance}$");
        }

        public void addInterest()
        {
            int i = (balance * rateOfInterest) / 100 * 3;
            Console.WriteLine($"Your interest is {i}$");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            PersonBankAccnt account = new PersonBankAccnt();
            do
            {
                Console.WriteLine("Enter 1 to change the name of bank");
                Console.WriteLine("Enter 2 to add amount");
                Console.WriteLine("Enter 3 to withdraw amount");
                Console.WriteLine("Enter 4 to calculate interest");
                Console.WriteLine("Enter 5 to Exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1: PersonBankAccnt.renameBank();
                        break;
                    case 2: account.Deposite();
                        break;
                    case 3: account.withdraw();
                        break;
                    case 4: account.addInterest();
                        break;
                }
            } while (n != 5);
            Console.WriteLine("Log out Successfylly");
            Console.ReadKey();
        }
    }
}
