using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        string userScore = Console.ReadLine();
        float score = float.Parse(userScore);
        string letter;
        string msg;
        string sign = "";

        // The letter
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Sign
        if (score % 10 >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (score % 10 <= 3 && letter != "F")
        {
            sign = "-";
        }

        // Final message
        if (score >= 70)
        {
            msg = "Congratulations you pass!";
        }
        else
        {
            msg = "Your score was not enough to pass, but it is normal, try again, you will get the missing score easily";
        }

        Console.WriteLine($"You got {sign}{letter}.");
        Console.WriteLine(msg);
    }
}