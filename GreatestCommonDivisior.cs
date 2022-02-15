using System;

namespace GCD // Greatest Common Divisior
{
    class Program
    {
        static double GCD(int a, int b) => b != 0 ? GCD(b, a % b) : a;

        static void Main(string[] args)
        {
            Console.WriteLine();
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GCD(a, b));
            Console.ReadKey();
        }
    }
}
