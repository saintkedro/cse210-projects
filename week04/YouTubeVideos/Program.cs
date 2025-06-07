using System;
//using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This program keeps track of YouTube videos
        // and comments left on them.

        // Create a list to store videos
        List<Video> videos = new List<Video>();

        // Create sample videos and set values for them
        // Each video should have a list of comments
        Video video1 = new Video("How to shoot and edit videos with a smartphone", "Kingsley Isong", 600);
        video1.AddComment(new Comment("Lucy Jackson", "This was really helpful! Thank you."));
        video1.AddComment(new Comment("Joseph Anwana", "Great tips, thanks Man!"));
        video1.AddComment(new Comment("Sophia Joseph", "I'll use this for my YouTube videos."));

        Video video2 = new Video("Beginner’s Guide to Social Media Ads", "Jane Smith", 900);
        video2.AddComment(new Comment("David Sam", "Very beginner-friendly."));
        video2.AddComment(new Comment("Evelyn Okon", "Nice explanation. Thank you."));
        video2.AddComment(new Comment("Franklin Edem", "Can you help me run ads?"));

        Video video3 = new Video("God's Plan of Salvation", "Elder Daniels", 720);
        video3.AddComment(new Comment("Grace Umoh", "This brings me so much peace"));
        video3.AddComment(new Comment("Kedro I.", "Very uplifting. I am blessed"));
        video3.AddComment(new Comment("Isaac James", "I'll share this with my family."));
        video3.AddComment(new Comment("Abaziono Kingsley", "We are loving Children of God"));

        // Put each video in a list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetAuthorName()}: {comment.GetText()}");
            }
            Console.WriteLine(); // Blank line between videos
        }
    }
}