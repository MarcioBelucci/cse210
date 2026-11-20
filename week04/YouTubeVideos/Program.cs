using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 minutes", "Dev Academy", 600);
        Video video2 = new Video("OOP Tutorial", "Code Lab", 1200);
        Video video3 = new Video("The Principle of Abstraction", "Vibe Coding", 900);

        video1.AddComment(new Comment("Carlos", "Excelent explanation!"));
        video1.AddComment(new Comment("Ana", "Amazing content, congratulations."));
        video1.AddComment(new Comment("Josh", "It helped me with my final test!"));
        video2.AddComment(new Comment("Robert", "Why is encapsulation important?"));
        video2.AddComment(new Comment("Mary", "Thanks for examples with the C# sintax"));
        video2.AddComment(new Comment("Paul", "Someone else didn't understand how it works?"));
        video3.AddComment(new Comment("Marcos", "Please, brings the second part!"));
        video3.AddComment(new Comment("Brian", "I love this channel!"));
        video3.AddComment(new Comment("Susan", "Can you share the slides, please?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Total Comments: {video.CountComments()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}