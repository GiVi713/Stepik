using System;

namespace Lesson422
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("3");
            }
            else if (num1 == num2 || num1 == num3 || num2 == num3) Console.Write(2);
            else Console.WriteLine("0");
        }
    }
}
