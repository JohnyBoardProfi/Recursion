using System;

namespace SumOfSquares // 1^2 + 2^2 + 3^2 + ... + n^2
{
    class Program
    {
        static double SumOfSquares(double n) => n == 1 ? 1 : Math.Pow(n, n) + SumOfSquares(n - 1);

        static void Main(string[] args)
        {
            Console.WriteLine();
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(SumOfSquares(num));
            Console.ReadKey();
        }
    }
}
