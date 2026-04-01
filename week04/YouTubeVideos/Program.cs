using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Dog", "John Brown", 120);
        Video video2 = new Video("Cat", "Mary scartman", 75);
        Video video3 = new Video("Boy", "luke Lisboa", 25);
        Video video4 = new Video("Fly", "Steve Crowder", 30);

        // Video 1
        video1.CommentVideo(new Comment("Anna", "I loved this video!"));
        video1.CommentVideo(new Comment("Brian", "Very good!"));
        video1.CommentVideo(new Comment("Carlos", "Great content!"));

        // Video 2
        video2.CommentVideo(new Comment("Daniel", "Nice"));
        video2.CommentVideo(new Comment("Eva", "Cool content"));
        video2.CommentVideo(new Comment("Frank", "Thanks!"));

        // Video 3
        video3.CommentVideo(new Comment("Gabriela", "Very interesting"));
        video3.CommentVideo(new Comment("Henry", "I learned a lot"));
        video3.CommentVideo(new Comment("Isabella", "Clear explanation"));
        video3.CommentVideo(new Comment("John", "Great job on the video!"));

        // Video 4
        video4.CommentVideo(new Comment("Karen", "I really liked it"));
        video4.CommentVideo(new Comment("Lucas", "Well explained"));
        video4.CommentVideo(new Comment("Mariana", "I will share this!"));


        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video i in videos)
        {

            Console.WriteLine("---------------------------");
            Console.WriteLine(i.GetInfoVideo());
            Console.WriteLine("");
            Console.WriteLine("------------");
            Console.WriteLine("");
            Console.WriteLine($"Number of comments:{i.NumberOfComments()} \n");
            Console.WriteLine(i.GetVideoComments());
        }

    }
}