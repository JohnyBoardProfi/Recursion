using System;

namespace Power // a ^ b without using Math.Pow
{
    class Program
    {
        static double Power(int a, int b)
        {
            double d = 0;
            if (b == 0)
            {
                d = 1;
            }
            else if (b < 0)
            {
                d = 1 / Power(a, -b);
            }
            else if (b == 1)
            {
                d = a;
            }
            else
            {
                d = b % 2 == 0 ? Power(a * a, b / 2) : a * Power(a * a, b / 2);
            }
            return d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(a, b));
            Console.ReadKey();
        }
    }
}
