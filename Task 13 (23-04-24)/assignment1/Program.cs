using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public Class classDetails;

        public Student(int id, string name, int age, Class classDetails)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.classDetails = classDetails;
        }
        public override string ToString()
        {
            return $"Student ID: {this.id}\nName: {this.name}\nAge: {this.age}\n{this.classDetails}\n================";
        }
    }

    class Class
    {
        public int id;
        public string course;

        public Class(int id, string course)
        {
            this.id = id;
            this.course = course;
        }
        public override string ToString()
        {
            return $"Class ID: {this.id}\nCourse: {this.course}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student(101, "Piyush", 21, new Class(1, "Mech")));
            studentList.Add(new Student(102, "Yash", 19, new Class(2, "E&TC")));
            studentList.Add(new Student(103, "Atharv", 12, new Class(3, "CSE")));
            studentList.Add(new Student(104, "Mayur", 20, new Class(4, "IT")));
            studentList.Add(new Student(105, "Vedant", 15, new Class(5, "Civil")));

            var students = from student in studentList where student.age > 18 select student;
            foreach(Student std in students)
            {
                Console.WriteLine(std);
            }
            Console.ReadKey();
        }
    }
}
