using System;

public abstract class Goal{
    // The goal name and description
    public string Name { get; set; }
    public string Description { get; set; }
    
    // The points for completing the goal
    public int Points { get; set; }

    // The constructor for creating a new goal
    public Goal(string name, string description, int points){
        Name = name;
        Description = description;
        Points = points;
    }

    // An abstract method to record an event for a goal (e.g., completing a task)
    public abstract void RecordEvent();

    // An abstract method to display the current progress of the goal
    public abstract void DisplayGoal();

    // An abstract method to return the total points earned from the goal
    public abstract int GetTotalPoints();
}