using System;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("Proverbs", 3, 5, 6);

        Scripture s1 = new Scripture(r1, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledged him, and he shall direct thy paths.");
        Console.WriteLine(s1.GetDisplayText());

        Console.WriteLine("");

        string response;
        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();

            Console.Clear();
            s1.HideRandomWords(1);
            Console.WriteLine(s1.GetDisplayText());
        } while (!(s1.IsCompletelyHidden() || response == "quit"));



    }
}