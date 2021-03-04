using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            double result;

            Console.WriteLine("Enter the radius of the circle:");
            radius = Convert.ToDouble(Console.ReadLine());
            result = radius * radius;
            Console.WriteLine("Area = {0}", result * pi);
        }
    }
}