using System;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Top 10 C# Tips", "ProgrammingGuru", 900);
        Video video3 = new Video("Advanced C# Techniques", "ExpertCoder", 1200);

        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Awesome video!"));

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
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Commenter: {comment.CommenterName} - {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}