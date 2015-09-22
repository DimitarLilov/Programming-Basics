using System;

    class FormattingNumbers
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("|{0,-10:X}|" ,a);
            Console.Write(Convert.ToString(a, 2).PadLeft (10, '0'));
            Console.WriteLine("|{0,10:0.##}|{1,-10:0.000}|",b ,c);
        }
    }

