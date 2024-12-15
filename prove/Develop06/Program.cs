using System;
using System.Collections.Generic;

/// <summary>
/// In this program I added a few differnt types of goals outside of the requirments. 
/// I also added a milestone system where users can recive bonus points after they 
/// meet a certian point amount. I added negative goals (bad habits) that effect the 
/// users score by removing points The last thing that i added to fill the "Shows 
/// creativity and exceeds core requirements" secton was a score and level system. 
/// Through this the user can increase their level as they increase their points with 
/// milestones that give the user a way to progress outside of points. The one area that 
/// After a long struggle I could not figure out how I couild implement the 
/// "Functionality: Saving/Loading" requirment correctly. How could I have implemented the save and load?
/// </summary>
class Program{
    static void Main(){
        // Creates a new user
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        User user = new User(name);

        // Displays the user options and run the main loop
        bool running = true;
        while (running){
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Progress");
            Console.WriteLine("6. Load Progress");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine(); 

            switch (choice){
                case "1":
                    user.CreateGoal(); // Creates a new goal
                    break;
                case "2":
                    user.RecordEvent(); // Records a goal completion
                    break;
                case "3":
                    user.DisplayGoals(); // Displays all goals
                    break;
                case "4":
                    user.DisplayScore(); // Displays the score and level
                    break;
                case "5":
                    user.SaveProgress(); // Saves progress
                    break;
                case "6":
                    user.LoadProgress(); // Loads progress
                    break;
                case "7":
                    running = false; // Exits the program
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

}