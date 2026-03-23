public class Versicle
{

    private int _versicleNumber;
    private List<Word> _words = new List<Word>();
    private List<int> indexOfWordsAvailable = new List<int>();

    public Versicle(int versicle, string text)
    {

        _versicleNumber = versicle;

        // calling the builder of Word.
        string[] words = text.Split(" ");

        foreach (string i in words)
        {
            _words.Add(new Word(i));
        }
    }

    public string GetDisplayVersicle()
    {
        string text = "";
        for (int j = 0; j < _words.Count(); j++)
        {

            text += $"{_words[j].GetDisplay()}{(j == _words.Count() - 1 ? $"" : $" ")}";
        }
        return text;
    }
    public void HideRandomWords(int numberToHide)
    {

        updateNumberAvailable();

        if (numberToHide > indexOfWordsAvailable.Count())
        {
            numberToHide = indexOfWordsAvailable.Count();
        }

        for (int _ = 0; _ < numberToHide; _++)
        {
            Random random = new Random();
            int index = random.Next(indexOfWordsAvailable.Count());

            _words[indexOfWordsAvailable[index]].Hide();
            indexOfWordsAvailable.RemoveAt(index);
        }
    }


    public bool IsCompletedHidden()
    {
        bool isAllWordsHidden = true;
        for (int k = 0; k < _words.Count(); k++)
        {
            if (!(_words[k].IsHidden()))
            {
                isAllWordsHidden = false;
            }
        }
        return isAllWordsHidden;
    }

    private void updateNumberAvailable()
    {
        indexOfWordsAvailable.Clear();
        for (int k = 0; k < _words.Count(); k++)
        {
            if (!(_words[k].IsHidden()))
            {
                indexOfWordsAvailable.Add(k);
            }
        }
    }

    public string status()
    {

        updateNumberAvailable();
        int allWords = _words.Count();
        int available = indexOfWordsAvailable.Count();
        int wordsHidden = allWords - available;
        return $"Total words: {allWords}, visible words: {available}, hidden words: {wordsHidden}";
    }
}