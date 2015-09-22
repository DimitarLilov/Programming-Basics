using System;

    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            int divider = 0;
            int remainder = 0;
            bool inPrime= true;
            while (divider < n)
            {
              remainder = n % divider;
              if (remainder == 0)
              {
                  inPrime = false; 
              }
              divider++;
            }
            Console.WriteLine(inPrime);
        }
    }

