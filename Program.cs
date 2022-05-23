using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a difficulty level you want to try (Easy/Medium/Hard)? ");
            string diffLevel = Console.ReadLine();

            int counter = 0;
            bool continueGame = false;
            if (diffLevel == "easy" || diffLevel == "Easy")
            {
                counter = 8;
            }
            else if (diffLevel == "medium" || diffLevel == "Medium")
            {
                counter = 6;
            }
            else if (diffLevel == "hard" || diffLevel == "Hard")
            {
                counter = 4;
            }
            else
            {
                //Console.Write("Please enter a correct difficulty level: ");
                continueGame = true;
            }

            int secNumber = GenerateRandomNum();

            for (int i = 0; i < counter; i++)
            {
                Console.Write("Guess the secret number (1-100): ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                //Console.WriteLine(num);

                // Phase 2
                // int secNumber = 42;

                if (num == secNumber)
                {
                    Console.WriteLine("You guessed it right! Way to go...");
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess ({num})");
                    Console.WriteLine($"You have {(counter - 1) - i} more chances to guess.");

                    if (num > secNumber && num - secNumber >= 50)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    else if (num < secNumber && secNumber - num >= 50)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                }
            }

            while (continueGame)
            {
                Console.Write("Guess the secret number (1-100): ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                //Console.WriteLine(num);

                // Phase 2
                // int secNumber = 42;

                if (num == secNumber)
                {
                    Console.WriteLine("You guessed it right! Way to go...");
                    continueGame = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess ({num})");

                    if (num > secNumber && num - secNumber >= 50)
                    {
                        Console.WriteLine("Your guess is too high.");
                    }
                    else if (num < secNumber && secNumber - num >= 50)
                    {
                        Console.WriteLine("Your guess is too low.");
                    }
                }
            }
        }
        public static int GenerateRandomNum()
        {
            Random r = new Random();
            int secNum = r.Next(1, 101);
            Console.WriteLine($"Secret Number: {secNum}");
            return secNum;
        }
    }
}
