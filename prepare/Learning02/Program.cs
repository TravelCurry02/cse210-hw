using System;
class Program
{
    static void Main(string[] args)
    {
        // Here is the code for the jobs assinment
        Job job01 = new Job();
        job01._jobTitle = "Software Engineer";
        job01._companyName = "Microsoft";
        job01._startYear = 2012;
        job01._endYear = 2020;

        Job job02 = new Job();
        job02._jobTitle = "Supervisor";
        job02._companyName = "Apple";
        job02._startYear = 2020;
        job02._endYear = 2024; 

        Resume my_Resume = new Resume();
        my_Resume._name = "Iguss Self";

        my_Resume._jobs.Add(job01);
        my_Resume._jobs.Add(job02);

        my_Resume.Display();

        // Here is the code for the journals assinment

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