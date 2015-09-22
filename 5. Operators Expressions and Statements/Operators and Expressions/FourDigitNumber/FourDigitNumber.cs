using System;
using System.Collections.Generic;
using System.Linq;
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Number: ");
            string number = Console.ReadLine();
            char[] array = number.ToCharArray();
            int a = int.Parse(number[0].ToString());
            int b = int.Parse(number[1].ToString());
            int c = int.Parse(number[2].ToString());
            int d = int.Parse(number[3].ToString());
            Console.WriteLine("Sum of digits: {0}", a + b + c + d);
            Console.WriteLine("Reversed: {0}{1}{2}{3}",d ,c ,b ,a );
            Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
            
        }
    }
