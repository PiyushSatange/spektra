using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Employee
    {
        int id, salary;
        string name, job, location, department, gender;
        
        public object this[int i]
        {
            get
            {
                if (i == 0)
                    return id;
                else if (i == 1)
                    return name;
                else if (i == 2)
                    return job;
                else if (i == 3)
                    return salary;
                else if (i == 4)
                    return location;
                else if (i == 5)
                    return department;
                else if (i == 6)
                    return gender;
                else return 0;
            }
            set
            {
                if (i == 0)
                    id = (int)value;
                else if (i == 1)
                    name = (string)value;
                else if (i == 2)
                    job = (string)value;
                else if (i == 3)
                    salary = (int)value;
                else if (i == 4)
                    location = (string)value;
                else if (i == 5)
                    department = (string)value;
                else if (i == 6)
                    gender = (string)value;
            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e[0] = 1;
            e[1] = "Piyush";
            e[2] = "SSE";
            e[3] = 300000;
            e[4] = "Mumbai";
            e[5] = "IT";
            e[6] = "Male";
            Console.WriteLine($" Id:{e[0]}\n Name:{e[1]}\n job:{e[2]}\n salary:{e[3]}\n location:{e[4]}\n department:{e[5]}\n gender:{e[6]}");
            Console.WriteLine("=======After Modification======");
            e[0] = 2;
            e[1] = "Rohan";
            e[2] = "SE";
            e[3] = 500000;
            e[4] = "Pune";
            e[5] = "Sales";
            e[6] = "Male";
            Console.WriteLine($" Id:{e[0]}\n Name:{e[1]}\n job:{e[2]}\n salary:{e[3]}\n location:{e[4]}\n department:{e[5]}\n gender:{e[6]}");
            Console.ReadKey();
        }
    }
}
