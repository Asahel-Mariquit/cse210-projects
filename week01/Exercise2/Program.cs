using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Give your grade percentage: ");
        string userGradePercentage = Console.ReadLine();

        int convertedUserGradePercentage = int.Parse(userGradePercentage);

        string letter = "";
        if (convertedUserGradePercentage >= 90)
        {
            letter = "A";
        }
        else if (convertedUserGradePercentage >= 80)
        {
            letter = "B";
        }
        else if (convertedUserGradePercentage >= 70)
        {
            letter = "C";
        }
        else if (convertedUserGradePercentage >= 60)
        {
            letter = "D";
        }
        else if (convertedUserGradePercentage <= 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Please input a valid number");
        }

        string sign = "";
        int lastDigit = convertedUserGradePercentage % 10;

        if (lastDigit >= 7 && (letter != "A" && letter != "F"))
        {
            sign = "+";
        }
        else if (lastDigit <= 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        { Console.WriteLine($"Your grade is {letter}{sign}"); }

        if (convertedUserGradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Almost there. Please try again next time.");
        }


    }
}