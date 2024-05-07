using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Customers
    {
        public int id;
        public string name;
        public string address;
        public string city;
        public string country;

        public Customers(int id, string name, string address, string city, string country)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.city = city;
            this.country = country;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customers> customersList = new List<Customers>()
            {
                new Customers(1,"Piyush", "Kormangala 4th block", "Bangalore", "India"),
                new Customers(2, "John", "Street no 5", "New York", "USA"),
                new Customers(3, "Yash", "Juhu, Lane no 2", "Mumbai", "India"),
                new Customers(4,"JinSu", "stan li, street no 1", "Shinyang", "China"),
                new Customers(5, "Atharv", "Shivaji Nagar", "Delhi", "India"),
                new Customers(6, "Mario", "Hotel Line, 3rd floor", "Zurup", "Russia")
            };

            Predicate<Customers> filter = Customers => Customers.country == "India";
            Console.WriteLine("Running...");
            showCustomers(customersList, filter);
            Console.WriteLine("Running...");
            void showCustomers(List<Customers> list, Predicate<Customers> predicate)
            {
                
                foreach(var item in list)
                {
                    if (predicate(item))
                    {
                        Console.WriteLine($"ID : {item.id}, Name : {item.name}, Address : {item.address}, City : {item.city}, Country : {item.country}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
