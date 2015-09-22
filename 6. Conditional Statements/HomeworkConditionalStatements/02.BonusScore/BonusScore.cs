using System;

class BonusScore
{
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());
        if (score <= 0 || score >= 10)
        {
            Console.WriteLine("invalid score");
        }
        else if (score <= 3)
        {
            Console.WriteLine(score * 10);
        }
        else if (score == 4 || score == 5 || score == 6)
        {
            Console.WriteLine(score * 100);
        }
        else if (score == 7 || score == 8 || score == 9)
        {
            Console.WriteLine(score * 1000);
        }
    }
}

