using System;

namespace CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double ray, area;

            Console.Write("Enter the radius of the circle: ");
            ray = Convert.ToDouble(Console.ReadLine());

            area = PI * ray * ray;

            Console.WriteLine("The area of the circle is: " + area);
        }
    }
}

