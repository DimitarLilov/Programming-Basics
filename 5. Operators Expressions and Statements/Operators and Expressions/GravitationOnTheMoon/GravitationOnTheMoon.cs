using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Weight: ");
            float weight = float.Parse(Console.ReadLine());
            float weightOnMoon = (weight * 17 / 100);
            Console.WriteLine("Your weight on the moon will be {0} kg.", weightOnMoon);
        }
    }

