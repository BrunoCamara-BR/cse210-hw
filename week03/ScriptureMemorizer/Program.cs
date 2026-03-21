// levels


using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        int levelInput;
        bool isPlaying = true;

        while (isPlaying)
        {
            string refScripture = "John 3:5";
            string textScripture = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
            int wordsToHide = 0;

            Console.Clear();
            Console.WriteLine("Welcome to Scripture Memorizer\n");


            while (wordsToHide == 0)
            {
                Console.WriteLine("Choose the level");
                Console.WriteLine("1 - Easy (1 word per time)\n2- Medium (3 words per time)\n3 - Hard (10 words per time)\n4 - Machine (All words per time)");
                Console.Write("Typer the level (1-4): ");
                levelInput = int.Parse(Console.ReadLine());

                switch (levelInput)
                {
                    case 1:
                        wordsToHide = 1;
                        break;
                    case 2:
                        wordsToHide = 3;
                        break;
                    case 3:
                        wordsToHide = 10;
                        break;
                    case 4:
                        wordsToHide = 999;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nSorry this option is invalid\n");
                        wordsToHide = 0;
                        break;
                }
            }

            Scripture scripture = new Scripture(refScripture, textScripture);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            string option = "";

            while (option != "quit")
            {
                Console.WriteLine("Type enter to hide word or \"quit\" to exit");
                option = Console.ReadLine().ToLower();
                if (scripture.IsCompletedHidden())
                {
                    option = "quit";
                }
                if (option != "quit")
                {
                    scripture.HideRandomWords(wordsToHide);
                }
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

            }
            Console.WriteLine("Do you want play again (yes/no)?");
            isPlaying = !(Console.ReadLine().ToLower() == "no");
        }
    }
}

