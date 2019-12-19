using System;

namespace lesson421
{
    class Program
    {
        static void Main()
        {
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (-3 <= x && x <= 1 | 5 <= x && x <= 9)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
