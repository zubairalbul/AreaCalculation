﻿using System;
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
            
        }
        public class square : Shape
        {
            
        }
        class circle : Shape
        {
           
        }

        class triangle : Shape
        {
           
        }

        class rectangle : Shape
        {
          
        }

    }
}
