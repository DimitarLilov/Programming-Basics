﻿using System;
using System.Globalization;
class DecimalHexadecimalNumber
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());

        string hexaStr = dec.ToString("X");

        long hexa = long.Parse(hexaStr, NumberStyles.HexNumber);

        Console.WriteLine(hexaStr);
    }
}

