using System;
using System.Collections.Generic;
using System.IO;

public class Journal{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>{
    "Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?", 
    "Did I have any dreams that I could recall from last night if so what was the dream about?", 
    "What was the most stressful thing that I encountered today?", 
    "Was there anything that happened today that caused me to think differently?",
    "Was there anything that I overcame today", 
    "How did I challenge myself today?"

    };

    public void AddEntry(){
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
        Console.WriteLine("Entry added!");
    }

    public void DisplayEntries(){
        if (entries.Count == 0){
            Console.WriteLine("No entries to display");
            return;
        }

        foreach (var i in entries){
            Console.WriteLine(i);
        }
    }

    public void SaveToFile(string filename){
        using (StreamWriter writer = new StreamWriter(filename)){
            foreach (var i in entries){
                writer.WriteLine(i.ToCsv());
            }
        }
        
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename){
        if (!File.Exists(filename)){
            Console.WriteLine($"File {filename} does nor exist.");
            return;
        }

        entries.Clear();
        foreach (var i in File.ReadAllLines(filename)){
            var parts = i.Split("\",\"");
            if (parts.Length == 3){
                string date = parts[0].Trim('"');
                string prompt = parts[1].Trim('"');
                string response = parts[2].Trim('"');
                entries.Add(new Entry(prompt, response) {Date = date});
            }
        }

        Console.WriteLine($"Journal laoded from {filename}");
    }
}