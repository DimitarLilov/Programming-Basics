using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            int? variable1 = null;
            Console.WriteLine(variable1);
            double? variable2 = null;
            variable1 = 6;
            Console.WriteLine(variable1);
            variable2 = 43;
            Console.WriteLine(variable2);
        }
    }

