using System;
using System.Collections.Generic;

// The listing activity with prompts and item counting for the user's reflection
class ListingActivity : MindfulnessActivity{
    private static readonly List<string> Prompts = new(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "What are some positive experiences you had this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> usedPrompts = new();

    public override void RunActivity(){
        StartMessage("Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new();
        string prompt = GetUniquePrompt(random);
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You will have a few seconds to think before starting.\n");
        PauseWithSpinner(5);

        Console.WriteLine("Start listing items now. Press Enter after each item:");
        List<string> items = new();
        int elapsedTime = 0;

        while (elapsedTime < Duration){
            if (Console.KeyAvailable){
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    items.Add(input);
            }
            else{
                Thread.Sleep(100); // Preventative measures for a tight loop. This simulates the time passing
                elapsedTime += 1;
            }
        }

        Console.WriteLine($"\nTime's up! You listed {items.Count} items:");
        foreach (string item in items){
            Console.WriteLine($"- {item}");
        }

        EndMessage("Listing Activity");
    }

    private string GetUniquePrompt(Random random){
        if (usedPrompts.Count == Prompts.Count) usedPrompts.Clear(); // Reset if all prompts are used
        string prompt;
        do{
            prompt = Prompts[random.Next(Prompts.Count)];
        } while (usedPrompts.Contains(prompt));

        usedPrompts.Add(prompt);
        return prompt;
    }
}
