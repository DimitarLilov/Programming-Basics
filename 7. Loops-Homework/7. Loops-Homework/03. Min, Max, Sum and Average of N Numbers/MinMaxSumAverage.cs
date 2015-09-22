using System;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        double avg = sum / n;
        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}",avg);
    }
}

