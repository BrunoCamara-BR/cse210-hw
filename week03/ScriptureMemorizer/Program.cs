// Scripture Memorizer
// Author: Bruno Câmara dos Santos
// Description: This program helps the user memorize any verse by hiding words randomly, using different levels to adapt
// to the user's memorization skills.

// Enhancements:
// 1 - Levels: easy, medium, hard, machine
// 2 - Support for multiple verses
// 3 - Number of hidden words, visible words, and total word count indicator


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

            int wordsToHide = 0;

            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer\n");
            Console.WriteLine();

            // options to change
            Console.Write("Enter the reference (e.g., 'Alma 37:37' or 'John 3:5-7'): ");
            string referenceInput = Console.ReadLine();
            Scripture scripture = new Scripture(referenceInput);

            string textInput;
            // insert text versicles
            int firstVerse = scripture.GetFirstVerse();
            int lastVerse = scripture.GetLastVerse();
            if (lastVerse == 0)
            {
                lastVerse = firstVerse;
            }
            for (int i = firstVerse; i <= lastVerse; i++)
            {
                Console.Write($"Enter the text of verse {i}: ");
                textInput = Console.ReadLine();
                scripture.Addversicle(i, textInput);
            }

            bool again = true;
            while (again)
            {

                // choose the versicle to memorize
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayReference());
                Console.WriteLine($"Which verses do you want to study?");
                Console.WriteLine();
                int count = 0;
                for (int i = firstVerse; i <= lastVerse; i++)
                {
                    count++;
                    Console.WriteLine($"Option {count} - Verse {i}");
                }
                Console.WriteLine();
                Console.Write($"Enter the number of the option (e.g., 1): ");
                int versicleChosen = int.Parse(Console.ReadLine()) - 1;


                while (wordsToHide == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Choose a level:");
                    Console.WriteLine("1 - Easy (1 word at a time)\n2 - Medium (3 words at a time)\n3 - Hard (10 words at a time)\n4 - Machine (all words at once)");
                    Console.Write("Type the level (1-4): ");
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
                            Console.WriteLine("\nSorry, this option is invalid.\n");
                            wordsToHide = 0;
                            break;
                    }
                }

                Console.Clear();

                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(scripture.IndexVersicleStatus(versicleChosen));
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(scripture.GetDisplayReference());
                Console.WriteLine();
                Console.WriteLine($"\"{scripture.IndexVersicleShow(versicleChosen)}\"");
                Console.WriteLine();

                string option = "";

                while (option != "quit")
                {
                    Console.Write("Press Enter to hide more words or type \"quit\" to exit: ");
                    option = Console.ReadLine().ToLower();
                    if (scripture.IndexVersicleIsHidden(versicleChosen))
                    {
                        option = "quit";
                    }
                    if (option != "quit")
                    {
                        scripture.IndexVersicleToHide(versicleChosen, wordsToHide);
                    }
                    Console.Clear();
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(scripture.IndexVersicleStatus(versicleChosen));
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(scripture.GetDisplayReference());
                    Console.WriteLine();
                    Console.WriteLine($"\"{scripture.IndexVersicleShow(versicleChosen)}\"");
                    Console.WriteLine();
                }

                Console.Write("Do you want to choose another verse (yes/no)? ");
                again = !(Console.ReadLine().ToLower() == "no");
            }

            Console.Write("Do you want to restart the program (yes/no)? ");
            isPlaying = !(Console.ReadLine().ToLower() == "no");
        }
    }
}



