using System;

class SortNumbers
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        if (a >= b && a >= c && b >= c)
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);

        }
        else
            if (a >= b && a >= c && b <= c)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);

            }
            else
                if (b >= a && b >= c && a >= c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);

                }
                else
                    if (b >= a && b >= c && a <= c)
                    {
                        Console.WriteLine("{0} {1} {2}", b, c, a);

                    }
                    else
                        if (c >= a && c >= b && a >= b)
                        {
                            Console.WriteLine("{0} {1} {2}", c, a, b);

                        }
                        else
                            if (c >= a && c >= b && a <= b)
                            {
                                Console.WriteLine("{0} {1} {2}", c, b, a);

                            }

    }
}

