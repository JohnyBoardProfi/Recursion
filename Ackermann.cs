using System;

namespace Ackermann // Ackermann function
{
    class Program
    {
        static int A(uint m, n) => m == 0 ? n + 1 : (n == 0 ? A(m - 1, 1) : A(m - 1, A(m, n - 1)));
        
        static void Main(string[] args)
        {
            Console.WriteLine();
            uint m = Convert.ToUInt32(Console.ReadLine()), n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(SumOfSquares(num));
            Console.ReadKey();
        }
    }
}
