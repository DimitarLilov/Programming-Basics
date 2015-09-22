using System;

class Trapezoids
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double result = 0.5 * (a + b) * h;
        Console.WriteLine(result);
    }
}

