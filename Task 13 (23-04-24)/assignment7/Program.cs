using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace assignment7
{
    class Product
    {
        public int productId;
        public string productName;
        public int productQunt;
        public int productPrice;

        public Product(int productId, string productName, int productQunt, int productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productQunt = productQunt;
            this.productPrice = productPrice;
        }

        public override string ToString()
        {
            return $"Product ID : {this.productId}\nProduct Name : {this.productName}\nProduct Quantity : {this.productQunt}\nProduct Price : {this.productPrice}\n========================";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product(101, "Table", 5, 2000));
            list.Add(new Product(102, "Chair", 7, 1000));
            list.Add(new Product(103, "CPU", 3, 20000));
            list.Add(new Product(104, "Monitor", 9, 12000));
            list.Add(new Product(105, "Mouse", 15, 500));
            list.Add(new Product(106, "Keyboard", 8, 800));

            string json = JsonConvert.SerializeObject(list);
            Console.WriteLine(json);
            List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(json);
            foreach(Product p in productList)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
