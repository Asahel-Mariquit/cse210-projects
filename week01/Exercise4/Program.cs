using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        int sum = 0;
        int numberSize = 0;
        int average = 0;
        int maximum = -1;
        List<int> numbers;
        while (userInput != "0")
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            userInput = Console.ReadLine();
            int convertedNumber = int.Parse(userInput);

            numbers = new List<int>();

            if (convertedNumber != 0)
            {
                numbers.Add(convertedNumber);
            }

            foreach (int number in numbers)
            {
                sum += number;
                if (number >= maximum)
                {
                    maximum = number;
                }
            }

            numberSize += numbers.Count;
            average = sum / numberSize;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");
        
    }
}