using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudent
{
    class Person
    {
        public string name;
        public int age;
        public string address;

        public Person(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void showName()
        {
            Console.WriteLine("Name : " + this.name);
        }
        public void showAge()
        {
            Console.WriteLine("Age : " + this.age);
        }
        public void showAddress()
        {
            Console.WriteLine("Address : " + this.address);
        }
    }

    class Student : Person
    {
        public Student(string name, int age, string adderss) : base(name, age, adderss)
        {
        }
    }

    class Teacher : Person
    {
        public Teacher(string name, int age, string adderss) : base(name, age, adderss)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Piyush", 12, "bangalore");
            std.showAddress();
            std.showName();
            std.showAge();
            Teacher tch = new Teacher("Mohan", 45, "USA");
            tch.showAddress();
            tch.showName();
            tch.showAge();
            Console.ReadLine();
        }
    }
}
