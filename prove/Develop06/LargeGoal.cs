using System;

public class LargeGoal : Goal{
    public int TotalSteps { get; set; }
    public int CompletedSteps { get; set; }
    public int PointsPerStep { get; set; }

    public LargeGoal(string name, string description, int totalSteps, int pointsPerStep)
        : base(name, description, pointsPerStep * totalSteps){
        TotalSteps = totalSteps;
        CompletedSteps = 0;
        PointsPerStep = pointsPerStep;
    }

    public override void RecordEvent(){
        if (CompletedSteps < TotalSteps){
            CompletedSteps++;
            Console.WriteLine($"Step {CompletedSteps}/{TotalSteps} completed! You earned {PointsPerStep} points for this step.");
        }
        else{
            Console.WriteLine("You've already completed all steps for this large goal!");
        }
    }

    public override void DisplayGoal(){
        Console.WriteLine($"{Name}: {Description} - Completed {CompletedSteps}/{TotalSteps} steps.");
    }

    public override int GetTotalPoints(){
        return CompletedSteps * PointsPerStep;
    }
}
