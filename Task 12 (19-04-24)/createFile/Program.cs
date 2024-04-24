using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test2.txt";
            if (File.Exists(fileName))
            {
                Console.WriteLine("File already exist");
            }
            else
            {
                File.Create(fileName);
                Console.WriteLine("File created Successfully");
            }
            Console.ReadKey();
        }
    }
}
