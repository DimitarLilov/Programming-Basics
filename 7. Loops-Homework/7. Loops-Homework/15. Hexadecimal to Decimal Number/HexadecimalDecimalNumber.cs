using System;
using System.Globalization;
class HexadecimalDecimalNumber
{
    static void Main()
    {
        string hexa = Console.ReadLine();

        long dec = long.Parse(hexa, NumberStyles.HexNumber);

        Console.WriteLine(dec);
    }
}

