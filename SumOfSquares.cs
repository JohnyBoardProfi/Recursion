using System;

namespace SumOfSquares // 1^2 + 2^2 + 3^2 + ... + n^2
{
    class Program
    {
        static double F(double n) => n * (n + 1) * (2 * n + 1) / 6;

        static void Main(string[] args)
        {
            Console.WriteLine();
            double num = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(F(num));
            Console.ReadKey();
        }
    }
}
