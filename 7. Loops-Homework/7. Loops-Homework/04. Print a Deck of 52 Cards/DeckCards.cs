using System;

class DeckCards
{
    static void Main()
    {
        int a = 5;
        int b = 4;
        int c = 3;
        int d = 6;
        for (int i = 2; i < 15; i++)
        {
            if (i > 1 && i < 11)
            {
                Console.WriteLine("" + i + ((char)a) + " " + i + ((char)b) + " " + i + ((char)c) + " " + i + ((char)d) );

            }
            else
            {
                for (int j = i; j < i + 1; j++)
                    switch (i)
                    {
                        case 11: Console.WriteLine("" + "J" + ((char)a) + " " + "J" + (char)b + " " + "J" + (char)c + " " + "J" + ((char)d)); break;
                        case 12: Console.WriteLine("" + "Q" + ((char)a) + " " + "Q" + (char)b + " " + "Q" + (char)c + " " + "Q" + ((char)d)); break;
                        case 13: Console.WriteLine("" + "K" + ((char)a) + " " + "K" + (char)b + " " + "K" + (char)c + " " + "K" + ((char)d)); break;
                        case 14: Console.WriteLine("" + "A" + ((char)a) + " " + "A" + (char)b + " " + "A" + (char)c + " " + "A" + ((char)d)); break;
                    }
            }
        }
       
    }
}

