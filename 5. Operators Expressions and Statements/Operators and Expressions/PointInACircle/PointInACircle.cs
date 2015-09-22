using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());
            bool check = (x * x) + (y * y) <= 2 * 2;
            Console.WriteLine(check);
        }
    }

