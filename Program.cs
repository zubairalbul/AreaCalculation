using System;

namespace Simple_Hospital_Management_System2
{
    public class Area
    {
        static void Main(string[] args)
        {
            // Prompt user for shape choice
            Console.WriteLine("Please Select an shape:");
            Console.WriteLine(" 1. Circle");
            Console.WriteLine(" 2. Rectangle");
            Console.WriteLine(" 3. Triangle");
            Console.WriteLine(" 4. Square");
            Console.WriteLine(" 5. Exit");

            int Choice = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (Choice)
                {
                    case 1:
                        // Get user input for radius
                        Console.Write("Enter radius: ");
                        double radius = double.Parse(Console.ReadLine());
                        Shape C = new Circle(radius);
                        Console.WriteLine("Area of circle: " + C.Area());
                        break;
                    case 2:
                        // Get user input for length and width
                        Console.Write("Enter length: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Enter width: ");
                        double width = double.Parse(Console.ReadLine());
                        Shape R = new Rectangle(length, width);
                        Console.WriteLine("Area of rectangle: " + R.Area());
                        break;
                    case 3:
                        // Get user input for base and height
                        Console.Write("Enter base: ");
                        length = double.Parse(Console.ReadLine());
                        Console.Write("Enter height: ");
                        width = double.Parse(Console.ReadLine());
                        Shape T = new Triangle(length, width);
                        Console.WriteLine("Area of triangle: " + T.Area());
                        break;
                    case 4:
                        // Get user input for side
                        Console.Write("Enter side: ");
                        length = double.Parse(Console.ReadLine());
                        Shape S = new Square(length);
                        Console.WriteLine("Area of square: " + S.Area());
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                // Prompt user for another shape choice
                Console.WriteLine("Do you want to calculate the area of another shape? (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response != "y")
                {
                    break;
                }

                Console.WriteLine("Please Select an shape:");
                Console.WriteLine(" 1. Circle");
                Console.WriteLine(" 2. Rectangle");
                Console.WriteLine(" 3. Triangle");
                Console.WriteLine(" 4. Square");
                Console.WriteLine(" 5. Exit");

                Choice = int.Parse(Console.ReadLine());
            }
        }

        public abstract class Shape
        {
            protected double length;
            protected double width;

            public Shape(double length)
            {
                this.length = length;
            }

            public Shape(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public abstract double Area();
        }

        class Square : Shape
        {
            public Square(double side) : base(side) { }

            public override double Area()
            {
                return length * length;
            }
        }

        class Circle : Shape
        {
            public Circle(double radius) : base(radius) { }

            public override double Area()
            {
                return Math.PI * Math.Pow(length, 2);
            }
        }

        class Triangle : Shape
        {
            public Triangle(double baseLength, double height) : base(baseLength, height) { }

            public override double Area()
            {
                return 0.5 * length * width;
            }
        }

        class Rectangle : Shape
        {
            public Rectangle(double length, double width) : base(length, width) { }

            public override double Area()
            {
                return length * width;
            }
        }
    }
}