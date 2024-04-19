using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{

    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }
        public override double CalculateArea()
        {
            return Math.PI * r * r;
        }
    }

    class Square : Shape
    {
        private double s;

        public Square(double s)
        {
            this.s = s;
        }
        public override double CalculateArea()
        {
            return s * s;
        }
    }

    class Traingle : Shape
    {
        private double h;
        private double b;

        public Traingle(double h, double b)
        {
            this.h = h;
            this.b = b;
        }
        public override double CalculateArea()
        {
            return (b * h) / 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape sq = new Square(4);
            Shape cr = new Circle(5);
            Shape tr = new Traingle(5, 8);
            Console.WriteLine("area of square : "+sq.CalculateArea());
            Console.WriteLine("area of Circle : "+cr.CalculateArea());
            Console.WriteLine("area of Traingle: "+tr.CalculateArea());
            Console.ReadKey();
        }
    }
}
