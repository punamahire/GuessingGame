using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 1
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Guess the secret number: ");
                string input = Console.ReadLine();
                int num = int.Parse(input);
                //Console.WriteLine(num);

                // Phase 2
                // int secNumber = 42;
                Random r = new Random();
                int secNumber = r.Next(1, 100);
                if (num == secNumber)
                {
                    Console.WriteLine("You guessed it right! Way to go...");
                    break;
                }
                else
                {
                    Console.WriteLine($"Your guess ({num})");
                    Console.WriteLine($"You have {3 - i} more chances to guess.");
                }

            }

            // Phase 3 - wrapped code within for loop

        }
    }
}
