using System.Runtime.CompilerServices;

public class Comment
{
    private string _commentaryAuthor;
    private string _text;

    public Comment(string author, string text)
    {
        _commentaryAuthor = author;
        _text = text;
    }

    public string GetCommentInfo()
    {
        return $"Author:{_commentaryAuthor}\nCommentary:{_text}";
    }
}