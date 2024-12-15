using System;

public class SimpleGoal : Goal{
    // The constructor for a simple goal 
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points){
    }

    // This marks the goal as completed and adds the points
    public override void RecordEvent(){
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    }

    // This displays the simple goal details
    public override void DisplayGoal(){
        Console.WriteLine($"[ ] {Name}: {Description} ({Points} points)");
    }

    // Returns the total points for a completed simple goal
    public override int GetTotalPoints(){
        return Points;
    }
}