using System;
using System.Collections.Generic;

class ReflectionActivity : MindfulnessActivity{
    private static readonly List<string> Prompts = new(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    private List<string> usedPrompts = new();
    private List<string> usedQuestions = new();

    public override void RunActivity(){
        StartMessage("Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.");

        Random random = new();
        string prompt = GetUniqueItem(Prompts, ref usedPrompts, random);
        Console.WriteLine($"\n{prompt}\n");
        PauseWithSpinner(3);

        int elapsed = 0;
        while (elapsed < Duration){
            string question = GetUniqueItem(Questions, ref usedQuestions, random);
            Console.WriteLine(question);
            PauseWithSpinner(3);
            elapsed += 3;
        }
        EndMessage("Reflection Activity");
    }

    private string GetUniqueItem(List<string> source, ref List<string> used, Random random){
        if (used.Count == source.Count) used.Clear(); // A reset if all items are used
        string item;
        do{
            item = source[random.Next(source.Count)];
        } while (used.Contains(item));
        used.Add(item);
        return item;
    }
}
