using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Learning C#", "Okoth Okindo", 600);
        Video video2 = new Video("Cooking Pasta", "Chef Brian", 1200);
        Video video3 = new Video("Travel Vlog: Japan", "Sarah Lee", 1800);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very informative."));
        video1.AddComment(new Comment("Charlie", "Thanks for the help!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Dave", "I love pasta!"));
        video2.AddComment(new Comment("Eve", "This recipe is amazing!"));
        video2.AddComment(new Comment("Frank", "I'll try this at home."));

        // Add comments to video 3
        video3.AddComment(new Comment("Grace", "Japan looks beautiful."));
        video3.AddComment(new Comment("Heidi", "I want to visit Japan!"));
        video3.AddComment(new Comment("Ivan", "Thanks for sharing!"));

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine(); // For spacing between video details
        }
    }
}
