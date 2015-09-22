using System;

class PointCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool isInCircle = r * r >= (x - 1) * (x - 1) + (y - 1) * (y - 1);
        bool isInRectangle = (x >= -1) && (x <= 6) && (y >= -1) && (y <= 1);
        Console.WriteLine(isInCircle && !isInRectangle ? "yes" : "no");
    }
}

