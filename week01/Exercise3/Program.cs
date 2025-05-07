using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        int guessCount = 0;
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            Console.WriteLine($"The magic number is {magicNumber}");

            do
            {
                guessCount++;
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You took {guessCount} guess(s)");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Please input a valid number (int)");
                }
            }
            while (guess != magicNumber);
        Console.WriteLine("Do you want to keep playing (yes/no)? ");
        response = Console.ReadLine();
        }

    }
}