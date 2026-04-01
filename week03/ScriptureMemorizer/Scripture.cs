using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

public class Scripture
{
    private Reference _reference;

    private List<Versicle> _versicles = new List<Versicle>();

    public Scripture(string reference)
    {

        // calling the builder of reference.
        string book;
        int chapter;
        int verse;
        int endVerse;

        // examples
        // John 3:16
        // Proverbs 3:5-6

        string[] partsBook = reference.Split(" ");
        book = partsBook[0];

        string[] chapterParts = partsBook[1].Split(":");
        chapter = int.Parse(chapterParts[0]);

        if (chapterParts[1].Contains("-"))
        {
            string[] intParts = chapterParts[1].Split("-");
            verse = int.Parse(intParts[0]);
            endVerse = int.Parse(intParts[1]);
            // ranged reference building
            _reference = new Reference(book, chapter, verse, endVerse);
        }
        else
        {
            // normal reference building
            verse = int.Parse(chapterParts[1]);
            _reference = new Reference(book, chapter, verse);

        }
    }

    public string GetDisplayReference()
    {
        return _reference.DisplayReference();
    }


    public void Addversicle(int number, string text)
    {
        
        // building versicles
        _versicles.Add(new Versicle(number, text));
    }

    public int GetFirstVerse()
    {
        return _reference._verse;
    }
    public int GetLastVerse()
    {
        return _reference._endVerse;
    }

    public string IndexVersicleShow(int index)
    {
        return _versicles[index].GetDisplayVersicle();
    }

    public bool IndexVersicleIsHidden(int index)
    {
        return _versicles[index].IsCompletedHidden();
    }

    public string IndexVersicleStatus(int index)
    {
        return _versicles[index].status();
    }
    public void IndexVersicleToHide(int index, int times)
    {
        _versicles[index].HideRandomWords(times);
    }

    public int IndexCurrentNumber(int index)
    {
        return _versicles[index].CurrentNumber();
    }


}