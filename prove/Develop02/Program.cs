using System;

class Program{
    static void Main(string[] args){
    Journal journal = new Journal();
        string choice;

    do {
        Console.WriteLine("\nJournal Menu:"); 
        Console.WriteLine("1. Write a new entry"); 
        Console.WriteLine("2. Display the journal"); 
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file"); 
        Console.WriteLine("5. Exit"); Console.Write("Choose an option: "); 
        choice = Console.ReadLine();   

        switch (choice){
            case "1":
                journal.AddEntry();
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                Console.Write("Enter the filename to save to: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                break;
            case "4":
                Console.Write("Enter the filename to load from: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                break;
            case "5":
                Console.WriteLine("Exiting the program Goodbye.");
                break;
            } 
        } while (choice != "5");

    }
}