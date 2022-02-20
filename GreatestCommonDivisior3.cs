using System;

class GCD // written on c++
{
    int GCD (int a, int b) 
    {
        if (a % 2 == 0 && b % 2 == 0)
        {
            return 2 * GCD(a / 2.0, b / 2.0);
        }
        else if (a == 0 || b == 0)
        {
            return abs(a + b);
        }
        else if (a % 2 == 0)
        {
            return GCD(a / 2, b);
        }
        else
        {
            return abs(a) > abs(b) ? GCD(abs(a) - abs(b), b) : GCD(a, abs(b) - abs(a));
        }
    }
    
    static void Main() 
    {
        int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GCD(a, b));
    }
}
