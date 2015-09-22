using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            bool odd = n % 2 != 0;
            
            Console.WriteLine(odd);

        }
    }

