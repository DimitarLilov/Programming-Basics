using System;

class ExchangeIfGreater
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else
            if (a < b)
            {

                Console.WriteLine("{0} {1}", a, b);
            }
    }
}

