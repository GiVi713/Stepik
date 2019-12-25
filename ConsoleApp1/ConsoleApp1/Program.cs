using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int can = Convert.ToInt32(Console.ReadLine());
            int tasks = Convert.ToInt32(Console.ReadLine());
            int days = can / tasks;
            if (can % tasks == 0)
            {
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine(days + 1);
            }
        }
    }
}
