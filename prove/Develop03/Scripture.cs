using System;
using System.Collections.Generic;
using System.Linq;

// This class represents a scripture along with it's reference text
public class Scripture{
    public Reference Reference {get; private set;}
    private List<Word> Words {get; set;}

    public Scripture(Reference reference, string text){
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // This displays the scripture with hidden words
    public void Display(){
        Console.WriteLine(Reference);
        Console.WriteLine(string.Join(" ", Words));
    }

    // This randomly hides some of the words in the scripture
    public void HideWords(int count){
        Random random = new Random();
        var WordsToHide = Words.Where(word => !word.isHidden).OrderBy(_ => random.Next()).Take(count);

        foreach (var word in WordsToHide){
            word.Hide();
        }
    }
    // This checks if all the words are hidden 
    public bool AllWordsHidden(){
        return Words.All(word => word.isHidden);
    }
}