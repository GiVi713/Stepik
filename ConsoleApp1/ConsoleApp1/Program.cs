﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if ( num % 2 == 0)
            {
                Console.WriteLine(num + 2);
            }
            else
            {
                Console.WriteLine(num + 1);
            }
        }
    }
}
