using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int[,] arrayMatrix = new int[n, m];
        char firstLetter = 'a';
        for (char i = 'a'; i <= firstLetter + n - 1; i++)
        {
            for (char j = i; j < i + m; j++)
            {
                string letters = i.ToString() + j.ToString() + i.ToString();
                Console.Write("{0} ", letters);
            }
            Console.WriteLine();
        }


    }
}

