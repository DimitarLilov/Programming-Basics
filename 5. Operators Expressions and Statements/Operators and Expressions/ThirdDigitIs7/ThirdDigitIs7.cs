using System;

    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("Numbers: ");
            int n = int.Parse(Console.ReadLine());
            bool nDigit = ((n / 100) % 10) == 7;
            Console.WriteLine(nDigit);
        }
    }

