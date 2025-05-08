using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName("Please enter your name: ");
        int userNumber = PromptUserNumber("Please enter you favorite number: ");
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string prompt)
        {
            Console.Write(prompt);
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(string prompt)
        {
            Console.Write(prompt);
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber);

            return number;
        }

        static int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;

            return squaredNumber;
        }

        void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your favorite number is {squaredNumber}");
        }
    }
}