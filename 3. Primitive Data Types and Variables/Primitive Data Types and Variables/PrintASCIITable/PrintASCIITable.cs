using System;


class PrintsASCIITable
{
    static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
 
        
        for (char c = (char)033; c <= (char)255; c++)
        {
            Console.WriteLine(c);
        }


    }
}