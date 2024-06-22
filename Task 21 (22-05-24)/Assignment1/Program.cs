using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new StoreEntities();
            int n;
            do
            {
                Console.WriteLine("Press 1 : Buy Product");
                Console.WriteLine("Press 2 : Add into existing product");
                Console.WriteLine("Press 3 : Add new product");
                Console.WriteLine("Press 4 : Show all product");
                Console.WriteLine("Press 5 : Show product details");
                Console.WriteLine("Press 6 : Remove product");
                Console.WriteLine("Press 7 : Exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch(n)
                {
                    case 1:
                        context.buyProduct();
                        break;
                    case 2:
                        context.addIntoExestingStock();
                        break;
                    case 3:
                        context.addNewStock();
                        break;
                    case 4:
                        context.showAllProducts(); 
                        break;
                    case 5:
                        context.getProductDetails();
                        break;
                    case 6:
                        context.removeProduct();
                        break;
                    case 7:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Enter the valid number");
                        break;
                }

            } while (n != 7);
        }
    }
}
