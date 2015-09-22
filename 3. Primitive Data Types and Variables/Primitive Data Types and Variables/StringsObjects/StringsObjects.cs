using System;

    class StringsObjects
    {
        static void Main()
        {
            string word1 = "Hello";
            string word2 = "World";
            object greating = word1 + " " + word2;
            string castedGreating = (string)greating;
            Console.WriteLine(castedGreating);
        }
    }

