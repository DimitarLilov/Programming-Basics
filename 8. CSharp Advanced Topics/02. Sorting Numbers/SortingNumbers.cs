using System;
using System.Collections.Generic;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int>numb = new List<int>();
        for (int i = 0; i < n; i++)
        {
           int numbers = int.Parse(Console.ReadLine());
            numb.Add(numbers);
        }
        numb.Sort();
        Console.WriteLine();
        foreach (var item in numb)
        {
            Console.WriteLine(item);
        }
    }
}

