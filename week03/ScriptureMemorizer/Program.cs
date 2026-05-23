using System;

class Program
{
    static void Main(string[] args)
    {

        //  Added multiple scriptures
        //  Random scripture selection

        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            )
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type quit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}