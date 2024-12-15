using System;

public class ChecklistGoal : Goal{
    // The total number of times the goal must be completed
    public int TotalTimes { get; set; }
    
    // The current number of completions
    public int CompletedTimes { get; set; }
    
    // Bonus points awarded for completing the goal
    public int BonusPoints { get; set; }

    // Constructor for checklist goal
    public ChecklistGoal(string name, string description, int points, int totalTimes, int bonusPoints)
        : base(name, description, points){
        TotalTimes = totalTimes;
        CompletedTimes = 0;
        BonusPoints = bonusPoints;
    }

    // Record an event for the checklist goal
    public override void RecordEvent(){
        if (CompletedTimes < TotalTimes){
            CompletedTimes++;
            Console.WriteLine($"Completed {CompletedTimes}/{TotalTimes} times! You earned {Points} points.");
        }
        else{
            Console.WriteLine($"Goal '{Name}' is complete! You earned a bonus of {BonusPoints} points.");
        }
    }

    // Displays the checklist goal progress
    public override void DisplayGoal(){
        Console.WriteLine($"{Name}: {Description} - Completed {CompletedTimes}/{TotalTimes} times ({Points} points each, Bonus: {BonusPoints} points)");
    }

    // Returns the total points for a checklist goal
    public override int GetTotalPoints(){
        if (CompletedTimes >= TotalTimes){
            return Points * TotalTimes + BonusPoints;
        }
        return Points * CompletedTimes;
    }
}