using System;
using System.Collections.Generic;
using System.IO;

public class User{
    // The user's name
    public string Name { get; set; }

    // The list of goals that the user has created
    public List<Goal> Goals { get; set; } = new List<Goal>();

    // The user's current score based on completed goals
    public int Score { get; set; }

    // A constructor for creating a new user
    public User(string name){
        Name = name;
    }

    // This method checks for any milestones for example double points for reaching 5000 points
    public void CheckForMilestones(){
        if (Score >= 5000 && Score < 10000){
            Console.WriteLine("Congrats! You've unlocked a 2x bonus for your next goal!");
        }
        else if (Score >= 10000){
            Console.WriteLine("You've reached the Grandmaster level! All points are doubled for your next goals!");
        }
    }

    // This calculates the user's level based on their total score
    public int Level{
        get{
            return Score / 1000; // The user levels up every 1000 points
        }
    }

    // This records the completion of a goal
    public void RecordEvent(){
        Console.WriteLine("Enter the goal name to record event:");
        string goalName = Console.ReadLine();

        var goal = Goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));

        if (goal != null){
            goal.RecordEvent();
            Score += goal.GetTotalPoints();
            CheckForMilestones();
        }
        else{
            Console.WriteLine("Goal not found.");
        }
    }

    // Displays the user's score and level
    public void DisplayScore(){
        Console.WriteLine($"Your score: {Score} (Level {Level})");
    }

    // Displays all goals and their current progress
    public void DisplayGoals(){
        if (Goals.Count == 0){
            Console.WriteLine("No goals available.");
        }
        else{
            foreach (var goal in Goals){
                goal.DisplayGoal();
            }
        }
    }

    // This saves the user's goals and score to a file
    public void SaveProgress(){
        Console.WriteLine("Progress saved successfully!");
    }

    // This loads the user's goals and score from a file 
    public void LoadProgress(){
        Console.WriteLine("I'm not sure how to implement a Load progress function");
    }

    // This will create a new goal for the user
    public void CreateGoal(){
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Large Goal");
        Console.WriteLine("5. Negative Goal");

        string goalType = Console.ReadLine();

        Console.WriteLine("Enter the name of the goal:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter a description for the goal:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the points for each completion:");
        int points = int.Parse(Console.ReadLine());

        switch (goalType){
            case "1":
                Goals.Add(new SimpleGoal(name, description, points));
                Console.WriteLine($"Simple goal '{name}' created.");
                break;
            case "2":
                Goals.Add(new EternalGoal(name, description, points));
                Console.WriteLine($"Eternal goal '{name}' created.");
                break;
            case "3":
                Console.WriteLine("Enter the total number of completions required:");
                int totalCompletions = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for completing the goal:");
                int bonusPoints = int.Parse(Console.ReadLine());
                Goals.Add(new ChecklistGoal(name, description, points, totalCompletions, bonusPoints));
                Console.WriteLine($"Checklist goal '{name}' created.");
                break;
            case "4":
                Console.WriteLine("Enter the total number of steps in the large goal:");
                int totalSteps = int.Parse(Console.ReadLine());
                Goals.Add(new LargeGoal(name, description, totalSteps, points));
                Console.WriteLine($"Large goal '{name}' created.");
                break;
            case "5":
                Goals.Add(new NegativeGoal(name, description, points));
                Console.WriteLine($"Negative goal '{name}' created.");
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                break;
        }
    }
}