using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Data Programming", "Rai Flores", 600);
        video1.AddComment( new Comment("Luis", "Good video."));
        video1.AddComment( new Comment("Peter", "Thanks, I just nedeed that."));
        video1.AddComment( new Comment("Yoshimar", "I will waiting for more videos like this."));
        videos.Add(video1);

        Video video2 = new Video("Playing with C#", "Teofilo123", 900);
        video2.AddComment( new Comment("Patrick", "Nice video."));
        video2.AddComment( new Comment("Stacy", "Play more games in C# please."));
        video2.AddComment( new Comment("Sky", "Please, teach us how to do that!!"));
        videos.Add(video2);

        Video video3 = new Video("Web Development #1", "Valentino Rojas", 3000);
        video3.AddComment( new Comment("Brandon", "Thanks for explaining this Topic that I wanted so hard to learn in such an easy way."));
        video3.AddComment( new Comment("Matias", "I really enjoyed these 50 minutes!!"));
        video3.AddComment( new Comment("Christhofer", "Part 2 right now please"));
        videos.Add(video3);

        foreach(Video video in videos)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine("");
        }
        
    }
}