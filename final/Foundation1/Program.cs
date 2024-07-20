using System;

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Top 10 C# Tips", "ProgrammingGuru", 500);
        Video video3 = new Video("Advanced C# Techniques", "ExpertCoder", 1400);

        video1.AddComment(new Comment("James", "Great tutorial!"));
        video1.AddComment(new Comment("Bill", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charles", "Awesome video!"));

        video2.AddComment(new Comment("David", "Loved the tips."));
        video2.AddComment(new Comment("Eva", "Really useful."));
        video2.AddComment(new Comment("Frank", "Thanks for the advice!"));

        video3.AddComment(new Comment("Grace", "Very detailed."));
        video3.AddComment(new Comment("Hank", "Learned a lot."));
        video3.AddComment(new Comment("Ivy", "Can't wait to try these techniques."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Commenter: {comment.GetCommenterName()} - {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}
