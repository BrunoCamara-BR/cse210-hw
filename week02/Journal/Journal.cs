using System;
using System.IO;

public class Journal
{
    // Attributes
    List<Entry> _entries = new List<Entry>();

    // Behaviors
    public void AddEntriesList(Entry userEntry)
    {
        _entries.Add(userEntry);
    }
    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nThere are no entries.\n");
        }
        else
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                Console.WriteLine($"\nEntry Number: {i + 1}\nDate: {_entries[i]._date}\nPrompt: {_entries[i]._prompt}\nAnswer: {_entries[i]._answer}\n");
            }
        }
    }

    public void EditAnswer(int number)
    {
        number--;
        Console.WriteLine($"\nEntry Number: {number + 1}\nDate: {_entries[number]._date}\nPrompt: {_entries[number]._prompt}\nAnswer: {_entries[number]._answer}\n\n");
        Console.WriteLine("Write your new answer:");
        _entries[number]._answer = Console.ReadLine();
        Console.WriteLine("\n*** The prompt answer has been updated.\n");
    }

    public void RemoveAnswer(int number)
    {
        number--;
        _entries.RemoveAt(number);
        Console.WriteLine("\n\n*** The entry has been deleted.\n");
    }

    public void SaveToFile(String fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName + ".csv"))
        {
            foreach (Entry j in _entries)
            {
                outputFile.Write($"{j._date}|{j._prompt}|{j._answer}\n");
            }
        }
        Console.WriteLine($"\n*** The file {fileName}.csv has been saved.");
    }

    public void ImportFile(String fileName, Entry entry)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName + ".csv");

        foreach (String l in lines)
        {
            string[] parts = l.Split("|");
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._answer = parts[2];

            AddEntriesList(entry);
        }
        Console.WriteLine($"\n*** The file {fileName}.csv has been imported.");
    }

}
