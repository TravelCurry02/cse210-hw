using System;

public class NegativeGoal : Goal{
    public bool IsTriggered { get; set; }

    public NegativeGoal(string name, string description, int points)
        : base(name, description, points){
        IsTriggered = false;
    }

    public override void RecordEvent(){
        if (!IsTriggered){
            IsTriggered = true;
            Console.WriteLine($"You lost {Points} points for {Name}.");
        }
        else{
            Console.WriteLine("This bad habit has already been triggered.");
        }
    }

    public override void DisplayGoal(){
        string status = IsTriggered ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name}: {Description} ({-Points} points)");
    }

    public override int GetTotalPoints(){
        return IsTriggered ? -Points : 0;
    }
}