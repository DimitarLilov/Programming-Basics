using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine((n >> p) & 1);
        }
    }

