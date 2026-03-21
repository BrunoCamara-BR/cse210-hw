using System.Data;

public class Reference
{
    private string _book;
    private int _charpter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int charpter, int verse)
    {
        _book = book;
        _charpter = charpter;
        _verse = verse;
        _endVerse = 0;

    }

    public Reference(string book, int charpter, int verse, int endVerse)
    {
        _book = book;
        _charpter = charpter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string DisplayReference()
    {
        return $"{_book} {_charpter}: {(_endVerse == 0 ? $"{_verse}" : $"{_verse}-{_endVerse}")}";
    }
}