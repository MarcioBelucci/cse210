using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 minutes", "Dev Academy", 600); 
        Video video2 = new Video("OOP Tutorial", "Code Lab", 1200);  

        video1.AddComment(new Comment("Carlos", "Excelent explanation!")); 
        video1.AddComment(new Comment("Ana", "Amazing content, congratulations.")); 
        video1.AddComment(new Comment("Josh", "It helped me with my final test!"));
        video2.AddComment(new Comment("Robert", "Why is encapsulation important?")); 
        video2.AddComment(new Comment("Mary", "Thanks for examples with the C# sintax"));
        
        videos.Add(video1); 
        videos.Add(video2);

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