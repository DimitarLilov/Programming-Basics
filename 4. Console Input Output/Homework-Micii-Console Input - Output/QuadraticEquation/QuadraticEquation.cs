using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c= ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant >= 0)
            {
                Console.Write("x1= ");
                Console.WriteLine((-b - Math.Sqrt(discriminant)) / (2 * a));
                Console.Write("x2= ");
                Console.WriteLine((-b + Math.Sqrt(discriminant)) / (2* a));
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }

