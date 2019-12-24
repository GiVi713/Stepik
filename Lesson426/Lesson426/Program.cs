using System;

namespace Lesson426
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 3:
                case 4:
                case 5: Console.WriteLine("Весна");break;
                case 6:
                case 7:
                case 8: Console.WriteLine("Лето");break;
                case 9:
                case 10:
                case 11: Console.WriteLine("Осень");break;
                case 12:
                case 1:
                case 2: Console.WriteLine("Зима");break;
            }

        }
    }
}
