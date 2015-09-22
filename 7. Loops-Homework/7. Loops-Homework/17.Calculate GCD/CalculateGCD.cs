using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int c = 0;

        while (b != 0)
        {
            c = b;
            b = a % b;
            a = c;
        }

        Console.WriteLine(a);
    }
}

