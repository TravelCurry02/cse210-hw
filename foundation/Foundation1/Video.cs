using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Video{
    public string Title {get; set;}
    public string Author {get; set;}
    public int Length {get; set;} // in seconds
    public List<Comment> Comments {get; set;}

    // This is a construtor to initialize the video
    public Video(string title, string author, int length){
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>(); // Creates an empty list fo comments
    }

    // This is a method that returns the number of comments 
    public int GetNumberOfComments(){
        return Comments.Count;
    }

    // This is a method that adds a comment to the video
    public void AddComment(Comment comment){
        Comments.Add(comment);
    }
}
