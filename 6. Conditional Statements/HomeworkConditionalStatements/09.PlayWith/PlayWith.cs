using System;

    class PlayWith
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            string comand = Console.ReadLine();

            switch (comand)
            {
                case "1":
                    Console.WriteLine("Please enter a int:");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(++number); break;
                case "2":
                    Console.WriteLine("Please enter a double:");
                    double numberdDuble = double.Parse(Console.ReadLine());
                    Console.WriteLine(numberdDuble + 1.0); break;
                case "3":
                    Console.WriteLine("Please enter a string:");
                    string str = Console.ReadLine();
                    Console.WriteLine(str  + "*"); break;
            }
        }
    }

