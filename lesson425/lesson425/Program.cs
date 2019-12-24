using System;

namespace lesson425
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Convert.ToString(Console.ReadLine());
            switch (month)
            {
                case "1": Console.WriteLine(31);break;
                case "2": Console.WriteLine(29); break;
                case "3": Console.WriteLine(31); break;
                case "4": Console.WriteLine(30); break;
                case "5": Console.WriteLine(31); break;
                case "6": Console.WriteLine(30); break;
                case "7": Console.WriteLine(31); break;
                case "8": Console.WriteLine(31); break;
                case "9": Console.WriteLine(30); break;
                case "10": Console.WriteLine(31); break;
                case "11": Console.WriteLine(30); break;
                case "12": Console.WriteLine(31); break;
            }
        }
    }
}
