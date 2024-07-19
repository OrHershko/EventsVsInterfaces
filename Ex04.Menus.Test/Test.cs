using System;

namespace Ex04.Menus.Test
{
    public static class Test
    {
        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 24.2.4.9504");
        }

        public static void CountCapitals()
        {
            Console.Write("Please enter a sentence: ");

            string sentence = Console.ReadLine();
            int capitalCount = 0;

            foreach (char letter in sentence)
            {
                if (char.IsUpper(letter))
                {
                    capitalCount++;
                }
            }

            Console.WriteLine($"Number of uppercase letters: {capitalCount}");
        }

        public static void ShowTime()
        {
            Console.WriteLine($"Current Time: {DateTime.Now.ToShortTimeString()}");
        }

        public static void ShowDate()
        {
            Console.WriteLine($"Today's Date: {DateTime.Now.ToShortDateString()}");
        }
    }
}
