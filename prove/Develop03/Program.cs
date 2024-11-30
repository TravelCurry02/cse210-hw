using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List<Scripture>{
            new Scripture(new Reference("John", "3", "16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", "3", "5", "6"), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
        };

        // Randomly chooses a scripture
        Random random = new Random();
        var selectedScripture = scriptures[random.Next(scriptures.Count)];

        Console.Clear();
        Console.WriteLine("Spriture Memorizer");
        Console.WriteLine("------------------");
        Console.WriteLine("Press enter to hide more words or type 'quit' to exit the program");
        Console.WriteLine();

        
        // main loop
        while (true){
            selectedScripture.Display();

            if (selectedScripture.AllWordsHidden()){
                Console.WriteLine("All words are hidden good job!");
                break;
            }

            Console.Write("Press enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            break;

            // This hides two of the words at a time 
            selectedScripture.HideWords(2);
            Console.Clear();
        }
    }
}