using System;
using System.Collections.Generic;
class Program{
    static void Main(){
        //This creates a list of videos
        List<Video> videos = new List<Video>();  

        // This creates videos
        Video video_01 = new Video("Funny cats", "Jerry's World", 600);

        // These will add comments to video
        video_01.AddComment(new Comment("Jake", "This is so funny!"));
        video_01.AddComment(new Comment("Sarah", "I love cats. Even more than dogs."));
        video_01.AddComment(new Comment("Evan", "Cats are so weird."));
        videos.Add(video_01);

        // Repeate for the rest of the videos 
        Video video_02 = new Video("Travel Log #4: Fixing the camper", "Map Quest", 900);

        video_02.AddComment(new Comment("Jerry", "Sorry you had to stop on your road trip to get that fixed."));
        video_02.AddComment(new Comment("Eli", "I'm just glad they caught that before it got too serious."));
        video_02.AddComment(new Comment("Thomas", "I could never live like you guys do."));
        video_02.AddComment(new Comment("Jannet", "Hopefully that did not tkae too much money from your guys savings."));
        videos.Add(video_02);

        Video video_03 = new Video("How to bake bananna bread", "Dan's Bakery", 360);

        video_03.AddComment(new Comment("Izzy", "That was so easy for me to follow!"));
        video_03.AddComment(new Comment("George", "Great recipe my family loved it."));
        video_03.AddComment(new Comment("Amy", "My house smelled so good after I made a loaf"));
        videos.Add(video_03);

        // This displays the details of every video in the list
        foreach (var video in videos){
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments){
                Console.WriteLine($" {comment.Name}: {comment.Text}");
            }
            Console.WriteLine("-----------------------");
        }
    }
}
