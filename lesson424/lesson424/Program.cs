using System;

namespace lesson424
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1, x2;
            if ( d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                if (x1 > x2)
                {
                    Console.WriteLine(x2);
                    Console.WriteLine(x1);
                }
                else
                {
                    Console.WriteLine(x1);
                    Console.WriteLine(x2);
                }
            }
            if (d == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine(x1);
            }
        }
    }
}
