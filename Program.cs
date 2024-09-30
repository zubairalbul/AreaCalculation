using System;
using static Simple_Hospital_Management_System2.Area;
using System.Drawing;

namespace Simple_Hospital_Management_System2
{
    public class Area
    {
        static void Main(string[] args)
        {
            // Get user input for length and width
            Console.Write("Enter length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());


            // Create shapes and calculate areas
            Shape C = new circle(width);
            Shape R = new rectangle(length, width);
            Shape T = new triangle(length, width);
            Shape S = new square(width);

            Console.WriteLine("Area of circle: " + C.Area());
            Console.WriteLine("Area of rectangle: " + R.Area());
            Console.WriteLine("Area of triangle: " + T.Area());
            Console.WriteLine("Area of square: " + S.Area());
        }

        public abstract class Shape
        {
            

            public Shape(double length, double width)
            
        }
        class Square : Shape
        {
            public Square(double side) : base(side) { }

            public override double Area()
            {
                return length * length;
            }
        }
        public class square : Shape
        {
            public square(double side) : base(side) { }

            public override double Area()
            {
                return length * length;
            }
        }
        class circle : Shape
        {
            public circle(double radius) : base(radius) { }

            public override double Area()
            {
                return Math.PI * Math.Pow(length, 2);
            }
        }

        class triangle : Shape
        {
            public triangle(double baseLength, double height) : base(baseLength, height) { }

            public override double Area()
            {
                return 0.5 * length * width;
            }
        }

        class rectangle : Shape
        {
            public rectangle(double length, double width) : base(length, width) { }

            public override double Area()
            {
                return length * width;
            }
        }

    }
}
