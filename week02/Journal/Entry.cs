using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    // Attributes
    public String _prompt;
    public String _answer;
    public String _date;


    // Behaviors
    public Boolean Write(String userPrompt)
    {
        DateTime today = DateTime.Now;
        bool isValid = false;


        Console.WriteLine(userPrompt);
        _answer = Console.ReadLine();

        if (_answer != "")
        {
            _prompt = userPrompt;
            _date = today.ToShortDateString();

            isValid = true;
            Console.WriteLine("\nYour entry has been saved.\n");
        }
        else
        {
            Console.WriteLine("\nThe entry was discarded.\n");
        }
        return isValid;
    }
}
