using System;

namespace SumOfSeries // 1 + 1/3 + 1/9 + ... + 1 / (3^n)
{
    class Program
    {
        static double SumOfSeries(double n) => n == 0 ? 1 : 1 / (double)Math.Pow(3, n) + SumOfSeries(n - 1);

        static void Main(string[] args)
        {
            Console.WriteLine();
            uint num = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(SumOfSeries(num));
            Console.ReadKey();
        }
    }
}
