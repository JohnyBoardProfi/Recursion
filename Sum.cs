using System;

namespace Sum
{
    class Program
    {
        static ulong Sum(ulong n) => n == 0 ? 0 : n + Sum(n - 1); // Gauss method is more efficient.

        static void Main(string[] args)
        {
            Console.WriteLine("This program can write sum of natural numbers from 1 to given number. Please, write it!");
            ulong num = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine(Sum(num));
            Console.ReadKey();
        }
    }
}
