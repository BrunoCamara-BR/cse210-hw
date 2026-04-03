using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Dog jumping", "John Brown", 120);
        Video video2 = new Video("Cat running", "Mary scartman", 75);
        Video video3 = new Video("Boy playing soccer", "luke Lisboa", 25);
        Video video4 = new Video("Birds Flying", "Steve Crowder", 30);

        // Video 1
        video1.AddCommentVideo(new Comment("Anna", "I loved this video!"));
        video1.AddCommentVideo(new Comment("Brian", "Very good!"));
        video1.AddCommentVideo(new Comment("Carlos", "Great content!"));

        // Video 2
        video2.AddCommentVideo(new Comment("Daniel", "Nice"));
        video2.AddCommentVideo(new Comment("Eva", "Cool content"));
        video2.AddCommentVideo(new Comment("Frank", "Thanks!"));

        // Video 3
        video3.AddCommentVideo(new Comment("Gabriela", "Very interesting"));
        video3.AddCommentVideo(new Comment("Henry", "I learned a lot"));
        video3.AddCommentVideo(new Comment("Isabella", "Clear explanation"));
        video3.AddCommentVideo(new Comment("John", "Great job on the video!"));

        // Video 4
        video4.AddCommentVideo(new Comment("Karen", "I really liked it"));
        video4.AddCommentVideo(new Comment("Lucas", "Well explained"));
        video4.AddCommentVideo(new Comment("Mariana", "I will share this!"));


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
            Console.WriteLine($"Number of comments:{i.GetNumberOfComments()} \n");
            Console.WriteLine(i.GetVideoComments());
        }

    }
}