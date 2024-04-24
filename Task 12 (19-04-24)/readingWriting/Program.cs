using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readingWriting { 
    class Program
    {
        static void addText(string name, string data)
        {
            File.AppendAllText(name, data);
            Console.WriteLine("Data added successfully");
        }
        static string readFile(string name)
        {
            return File.ReadAllText(name);
        }

        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\lenovo\\Desktop\\Spektra\\Task 12 (19-04-24)\\readingWriting\\test.txt";
            addText(fileName, "My name is piyush");
            Console.WriteLine(readFile(fileName));
            Console.ReadKey();
        }

    }
}