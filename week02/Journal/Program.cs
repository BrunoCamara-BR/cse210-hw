// =================================================================================================
// Project: My Journal Program
// Author : Bruno Câmara dos Santos
// Version: 1.0
// Date   : 03/12/2026
//
// Description:
// A console-based journal application that allows users to record daily entries by responding
// to prompts. The program lets users create new entries, view them, edit existing ones,
// delete entries, and save or load journal data from files.
//
// Exceeding Requirements:
// 1 - The program uses CSV files to store and load journal entries.
// 2 - A "Manage" menu was implemented, providing a submenu to work with existing entries:
//     2.1 - Edit an entry
//     2.2 - Remove an entry
//
// =================================================================================================

using System;

class Program
{
    static void Main(string[] args)
    {

        List<String> prompts = [
            "What did you learn or study today that excited you?",
            "What good things or surprises happened today?",
            "What was your favorite moment of the day?",
            "Which places did you visit or explore today?",
            "What delicious foods did you enjoy today?"
        ];
        PromptGenerator userPrompts = new PromptGenerator();
        userPrompts.AddPrompts(prompts);
        Entry entryUser = new Entry();
        Journal jornalUser = new Journal();
        int option;
        string currentPrompt;
        string fileName;
        int subOption;
        int entryNumber;

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {
            // options
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Manage");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());


            Console.WriteLine("-------------------------------");
            if (option == 1)
            {
                entryUser = new Entry();
                currentPrompt = userPrompts.Prompt();
                if (entryUser.Write(currentPrompt))
                {
                    jornalUser.AddEntriesList(entryUser);
                }
            }
            else if (option == 2)
            {
                do
                {

                    Console.WriteLine("All entries:\n");
                    jornalUser.Display();
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Options:");
                    Console.WriteLine("1. Edit prompt answer");
                    Console.WriteLine("2. Delete entry");
                    Console.WriteLine("3. Previous menu");
                    Console.Write("Please select an option: ");
                    subOption = int.Parse(Console.ReadLine());
                    if (subOption == 1)
                    {
                        Console.WriteLine("-------------");
                        Console.Write("Enter the note number to edit: ");
                        entryNumber = int.Parse(Console.ReadLine());

                        jornalUser.EditAnswer(entryNumber);
                    }
                    else if (subOption == 2)
                    {
                        Console.WriteLine("-------------");
                        Console.Write("Enter the entry number to remove: ");
                        entryNumber = int.Parse(Console.ReadLine());

                        Console.Write("\nAre you sure you want to delete this entry (yes/no)? ");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            jornalUser.RemoveAnswer(entryNumber);
                        }
                        else
                        {
                            Console.WriteLine("\n\n*** Operation canceled.");
                        }
                    }
                } while (subOption != 3);
            }
            else if (option == 3)
            {
                Console.Write("Import: Enter the file name (e.g., file): ");
                fileName = Console.ReadLine();
                jornalUser.ImportFile(fileName, entryUser);

            }
            else if (option == 4)
            {
                Console.WriteLine("Save: Enter the file name (e.g., file): ");
                fileName = Console.ReadLine();
                jornalUser.SaveToFile(fileName);
            }
        } while (option != 5);
    }
}
