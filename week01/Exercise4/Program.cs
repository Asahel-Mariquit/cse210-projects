using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // initialize variables
        string userInput = "";
        float sum = 0;
        int numberSize = 0;
        int largest = -1;
        int smallest = 999999999;
        // Create list named numbers
        List<int> numbers = new List<int>();

        // Continuee loop until user input is 0
        while (userInput != "0")
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            userInput = Console.ReadLine();
            int convertedNumber = int.Parse(userInput);

            if (convertedNumber != 0)
            {
                numbers.Add(convertedNumber);
            }
        }
        // loop through list to get the sum, largest numbers, and smalest number
        foreach (int number in numbers)
        {
            sum += number;
            // Find the maximum or largest number
            if (number >= largest)
            {
                largest = number;
            }
            // Find the smallest number
            if (number <= smallest)
            {
                smallest = number;
            }
        }
        // get list count
        numberSize += numbers.Count;
        // compute average
        float average = sum / numberSize;
        // Print sum, average, largest number, and smallest number
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        // Sort list
        numbers.Sort();
        // Loop and print sorted list
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}