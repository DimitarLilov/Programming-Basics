using System;

    class ComparingFloats
    {

        static void Main()
        {
            Console.Write("Number A = ");
            decimal firstNum = decimal.Parse(Console.ReadLine());
            Console.Write("Number B = ");
            decimal secondNum = decimal.Parse(Console.ReadLine());
            bool compares =Math.Abs (firstNum - secondNum) < 0.000001M;
            Console.WriteLine(compares);
            
            
        }
    }

