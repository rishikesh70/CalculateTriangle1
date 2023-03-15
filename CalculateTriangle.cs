
using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of point A:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates of point B:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter coordinates of point C:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

            Console.WriteLine($"Side a: {Math.Round(a, 2)}");
            Console.WriteLine($"Side b: {Math.Round(b, 2)}");
            Console.WriteLine($"Side c: {Math.Round(c, 2)}");

            if (a == b && b == c)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is isosceles.");
            }

            double delta = 0.000001; // precision for right triangle check
            if (Math.Pow(b, 2) - (Math.Pow(a, 2) + Math.Pow(c, 2)) <= delta ||
                Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2)) <= delta ||
                Math.Pow(a, 2) - (Math.Pow(b, 2) + Math.Pow(c, 2)) <= delta)
            {
                Console.WriteLine("The triangle is a right triangle.");
            }

            double perimeter = a + b + c;
            Console.WriteLine($"Perimeter: {Math.Round(perimeter, 2)}");

            Console.WriteLine("Even numbers from 0 to the perimeter:");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
