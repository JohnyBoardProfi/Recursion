using System;

namespace isPrime
{
    class Program
    {
        static bool isPrime(uint n, int i) => n < 2 || n % i == 0 && n != 2 ? false : (i < n / 2 ? isPrime(n, i + 1) : true);

        static void Main(string[] args)
        {
            Console.WriteLine();
            uint n = Convert.ToUInt32(Console.ReadLine());
            if (isPrime(n, 2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }
    }
}
