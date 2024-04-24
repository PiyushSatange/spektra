using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalFile = "C:\\Users\\lenovo\\Desktop\\Spektra\\Task 12 (19-04-24)\\assignment1\\copy.txt";
            string copiedFile = "C:\\Users\\lenovo\\Desktop\\Spektra\\Task 12 (19-04-24)\\assignment1\\original.txt";
            File.Copy(copiedFile, originalFile, true);
            Console.WriteLine("File Copied Successfully");
            Console.ReadKey();
        }
    }
}
