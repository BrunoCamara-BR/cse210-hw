using System.Runtime.CompilerServices;

public class Comment
{
    private string _commentAuthor;
    private string _text;

    public Comment(string author, string text)
    {
        _commentAuthor = author;
        _text = text;
    }

    public string GetCommentInfo()
    {
        return $"Author:{_commentAuthor}\nCommentary:{_text}";
    }
}