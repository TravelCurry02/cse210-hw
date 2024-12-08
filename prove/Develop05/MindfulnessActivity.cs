using System;
using System.IO;
using System.Threading;

abstract class MindfulnessActivity{
    public int Duration { get; set; }

    // The standard starting message for all activities
    public virtual void StartMessage(string activityName, string description){
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(3);
    }

    // The standard ending message for all activities
    public virtual void EndMessage(string activityName){
        Console.WriteLine("\nGreat job!");
        Console.WriteLine($"You completed the {activityName} for {Duration} seconds.");
        LogActivity(activityName);
        PauseWithSpinner(3);
    }

    // A log for activity details that saves to a file for the stretch requirement 
    public void LogActivity(string activityName){
        string log = $"{DateTime.Now}: Completed {activityName} for {Duration} seconds.";
        File.AppendAllText("activity_log.txt", log + Environment.NewLine);
    }

    // A pause animation with spinner for the stretch reqirement
    public void PauseWithSpinner(int seconds, bool isSpinner = true){
        if (isSpinner){
            string[] spinner = { "|", "/", "-", "\\" };
            for (int i = 0; i < seconds * 4; i++){
                Console.Write($"\r{spinner[i % spinner.Length]}");
                Thread.Sleep(250);
            }
            Console.WriteLine();
        }
        else{
            for (int i = 0; i < seconds; i++){
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

    // THe abstract method that is implemented by derived classes
    public abstract void RunActivity();
}
