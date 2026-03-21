using System.Collections.Generic;
using System.ComponentModel;

public class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {

        // calling the builder of reference.
        string book;
        int charpter;
        int verse;
        int endVerse;

        // examples
        // John 3:16
        // Proverbs 3:5-6

        string[] partsBook = reference.Split(" ");
        book = partsBook[0];

        string[] partsCharpter = partsBook[1].Split(":");
        charpter = int.Parse(partsCharpter[0]);

        if (partsCharpter[1].Contains("-"))
        {
            string[] intParts = partsCharpter[1].Split("-");
            verse = int.Parse(intParts[0]);
            endVerse = int.Parse(intParts[1]);
            // ranged reference building
            _reference = new Reference(book, charpter, verse, endVerse);
        }
        else
        {
            // normal reference building
            verse = int.Parse(partsCharpter[1]);
            _reference = new Reference(book, charpter, verse);
        }

        // calling the builder of Word.
        string[] words = text.Split(" ");

        foreach (string i in words)
        {
            _words.Add(new Word(i));
        }

    }

    public string GetDisplayText()
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
        List<int> wordsAvailable = new List<int>();
        for (int k = 0; k < _words.Count(); k++)
        {
            if (!(_words[k].IsHidden()))
            {
                wordsAvailable.Add(k);
            }
        }

        if (numberToHide > wordsAvailable.Count())
        {
            numberToHide = wordsAvailable.Count();
        }

        for (int _ = 0; _ < numberToHide; _++)
        {
            Random random = new Random();
            int index = random.Next(wordsAvailable.Count());

            _words[wordsAvailable[index]].Hide();
            wordsAvailable.RemoveAt(index);
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
}