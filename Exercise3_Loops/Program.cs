using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain.Trim().ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have picked a magic number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a whole number.");
                    continue;
                }

                guessCount++;

                if (guess < magicNumber)
                    Console.WriteLine("Higher");
                else if (guess > magicNumber)
                    Console.WriteLine("Lower");
                else
                    Console.WriteLine("You guessed it!");
            }

            Console.WriteLine($"You made {guessCount} guesses.");
            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine() ?? "no";
        }

        Console.WriteLine("Thanks for playing!");
    }
}
