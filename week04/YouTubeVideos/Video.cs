using System.Security.Cryptography.X509Certificates;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void CommentVideo(Comment commentVideo)
    {
        _comments.Add(commentVideo);
    }

    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public string GetInfoVideo()
    {
        return $"Title:{_title},\n Author:{_author},\n Duration:{_length} seconds";
    }

    public string GetVideoComments()
    {
        string allCommentaries = "";
        for (int i = 0; i < _comments.Count; i++)
        {
            allCommentaries += $"Commentary Nº:{i + 1}\nAuthor:{_comments[i].GetCommentInfo()}\n\n";
        }
        return allCommentaries;
    }

}