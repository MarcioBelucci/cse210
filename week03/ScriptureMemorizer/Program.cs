// For the exceeding requirements: In the HideRandomWords method of the Scripture class, I added a check so that only words that are still visible are chosen to be hidden. This way, each round always hides the requested number of words and never wastes an attempt on a word that is already hidden.
using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        string input = "";

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
            if(input != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}