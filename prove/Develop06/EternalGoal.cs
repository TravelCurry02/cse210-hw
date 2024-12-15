using System; 

public class EternalGoal : Goal{
    // Constructor for eternal goal 
    public EternalGoal(string name, string description, int points)
        : base(name, description, points){
    }

    // This records an event and adds points for the eternal goals
    public override void RecordEvent(){
        Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
    }

    // This displays the eternal goal's details
    public override void DisplayGoal(){
        Console.WriteLine($"[ ] {Name}: {Description} ({Points} points per completion)");
    }

    // Return the points earned for each completion of the goal
    public override int GetTotalPoints(){
        return Points;
    }
}