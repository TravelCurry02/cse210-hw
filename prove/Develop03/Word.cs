using System;

// This class represents a word in a scripture verse
public class Word{
    public string Text {get; private set;}
    public bool isHidden {get; private set;}

    public Word(string text){
        Text = text;
        isHidden = false;
    }

    // The method to hide the word
    public void Hide(){
        isHidden = true;
    }

    // The method that returns the word or underscores if hidden
    public override string ToString()
    {
        return isHidden ? new string('_', Text.Length) : Text;
    }
}