using System;

    class DivideBy7And5
    {
        static void Main()
        {
            Console.Write("Еnter a number: ");
            int n = int.Parse(Console.ReadLine());
            bool divided = n % 7 == 0 && n % 5 == 0;
            if (n == 0)
            {
                divided = false;
            }
            Console.WriteLine("Divided by 7 and 5? {0}", divided);
        }
    }

