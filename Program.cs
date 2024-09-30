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
            bool EnterFlag = false;

            do
            {
                
                try
                {
                    
                    Console.WriteLine("Please Select an shape: ");
                    Console.WriteLine(" 1. Circle. \n 2. Rectangle. \n 3. Triangle. \n 4. Square.\n5. Exit ");
                    int Choice = int.Parse(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Console.Clear();
                            C.Area();
                            Console.WriteLine("Area of circle: " + C.Area());
                            break;
                        case 2:
                            Console.Clear();
                            R.Area();
                            Console.WriteLine("Area of rectangle: " + R.Area());
                            break;
                        case 3:
                            Console.Clear();
                            T.Area();
                            Console.WriteLine("Area of triangle: " + T.Area());
                            break;
                        case 4:
                            Console.Clear();
                            S.Area();
                            Console.WriteLine("Area of square: " + S.Area());
                            break;
                        case 5:
                            return;


                    }
                }
                catch (Exception ex) { Console.WriteLine("Invalid Input"); }
            } while (EnterFlag != true);
           
 
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
