// Mindfulness Program
// Author: Bruno Câmara dos Santos
// Description: This program helps the user achieve mindfulness through three exercises: Breathing,
// Reflection, and Listing.
// Enhancements:
// 1 - The reflection activity will never repeat the same prompt in a single session.
// 2 - Added a loading animation.
// 3 - Added two additional types of animations for exercises.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {

        // BREATHING EXERCISE
        string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Breathing breathing = new Breathing("Breathing", breathingDescription);

        // REFLECTION EXERCISE
        string reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Reflection reflection = new Reflection("Reflection", reflectionDescription);

        //Initial prompts
        reflection.AddStartPrompts("Think of a time when you stood up for someone else.");
        reflection.AddStartPrompts("Think of a time when you did something really difficult.");
        reflection.AddStartPrompts("Think of a time when you helped someone in need.");
        reflection.AddStartPrompts("Think of a time when you did something truly selfless.");

        //End prompts
        reflection.AddEndPrompts("Why was this experience meaningful to you?");
        reflection.AddEndPrompts("Have you ever done anything like this before?");
        reflection.AddEndPrompts("How did you get started?");
        reflection.AddEndPrompts("How did you feel when it was complete?");
        reflection.AddEndPrompts("What made this time different than other times when you were not as successful?");
        reflection.AddEndPrompts("What is your favorite thing about this experience?");
        reflection.AddEndPrompts("What could you learn from this experience that applies to other situations?");
        reflection.AddEndPrompts("What did you learn about yourself through this experience?");
        reflection.AddEndPrompts("How can you keep this experience in mind in the future?");

        // LISTING EXERCISE
        string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Listing listing = new Listing("Listing", listingDescription);

        listing.AddReflectPrompt("Who are people that you appreciate?");
        listing.AddReflectPrompt("What are personal strengths of yours?");
        listing.AddReflectPrompt("Who are people that you have helped this week?");
        listing.AddReflectPrompt("When have you felt the Holy Ghost this month?");
        listing.AddReflectPrompt("Who are some of your personal heroes?");

        int option = 0;

        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Welcome Mindfulness Program");
        Console.WriteLine();
        new ExerciseBase().LoadingAnimation();
        Console.WriteLine();

        Console.Clear();
        Console.WriteLine("Menu Options:");
        while (!(option == 4))
        {
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            if (!(option >= 1 && option <= 4))
            {
                Console.Clear();
                Console.WriteLine("Please enter with number from 1 to 4\n");
            }
            else
            {
                Console.Clear();
                switch (option)
                {
                    case 1:
                        breathing.StartMsg();
                        breathing.BreathingExercise();
                        breathing.EndMsg();
                        break;
                    case 2:
                        reflection.StartMsg();
                        reflection.ReflectionExercise();
                        reflection.EndMsg();
                        break;

                    case 3:
                        listing.StartMsg();
                        listing.ListingExercise();
                        listing.EndMsg();
                        break;
                }
            }
        }


    }
}