using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
    }

    public void Hide()
    {
        string wordHidden = "";
        for (int i = 0; i < _word.Count(); i++)
        {
            wordHidden += "-";
        }
        _word = wordHidden;
        _isHidden = true;
    }

    public void Show()
    {
        Console.WriteLine(_word);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        return _word;
    }
}