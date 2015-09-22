using System;

    class ExchangeVariable
    {
        static void Main(string[] args)
        {
            int variableA = 5;
            int varibaleB = 10;
            Console.WriteLine("Before:\na= {0} \nb= {1}  "   ,variableA ,varibaleB);
            int variableC = varibaleB;
            int variableD = variableA;
            Console.WriteLine("After:\na= {0} \nb= {1} ", variableC ,variableD);
        }
    }

