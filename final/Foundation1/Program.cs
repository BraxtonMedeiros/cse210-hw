using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the videos
        List<Video> videos = new List<Video>();

        // Create 3-4 videos and add them to the list
        Video video1 = new Video("Funny Cats", "John Smith", 120);
        video1.AddComment(new Comment("Alice", "This video is hilarious!"));
        video1.AddComment(new Comment("Bob", "I love cats!"));
        video1.AddComment(new Comment("Charlie", "This made my day!"));
        videos.Add(video1);

        Video video2 = new Video("Cooking Tutorial", "Jane Doe", 180);
        video2.AddComment(new Comment("David", "Great recipe!"));
        video2.AddComment(new Comment("Emily", "I'm definitely trying this!"));
        videos.Add(video2);

        Video video3 = new Video("Gaming Stream", "Mike Johnson", 240);
        video3.AddComment(new Comment("Frank", "Nice gameplay!"));
        video3.AddComment(new Comment("Grace", "I enjoy watching your streams!"));
        video3.AddComment(new Comment("Henry", "Keep up the good work!"));
        video3.AddComment(new Comment("Isabelle", "You're so entertaining!"));
        videos.Add(video3);

        // Iterate through the list of videos and display the information
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length (seconds): " + video.GetLength());
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment.GetName() + ": " + comment.GetText());
            }

            Console.WriteLine();
        }
    }
}