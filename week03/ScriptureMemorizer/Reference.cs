using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    public int _verse;
    public int _endVerse;


    public Reference(string book, int charpter, int verse)
    {
        _book = book;
        _chapter = charpter;
        _verse = verse;
        _endVerse = 0;

    }

    public Reference(string book, int charpter, int verse, int endVerse)
    {
        _book = book;
        _chapter = charpter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string DisplayReference()
    {
        return $"{_book} {_chapter}:{(_endVerse == 0 ? $"{_verse}" : $"{_verse}-{_endVerse}")}";
    }

}