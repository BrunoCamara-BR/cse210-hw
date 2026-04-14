// Eternal Quest Program
// Author: Bruno Câmara
// Description: This application allows users to create personal goals, track their progress, and earn points by recording accomplishments. It encourages consistency, motivation, and personal growth.
//
// Enhancements:
// - Option to remove goals
// - Bonus feedback system
// - Animations to improve user experience:
//   1. Welcome message animation
//   2. Introduction/tutorial animation
//   3. Loading animations
//   4. Multiple animations displayed after completing actions

using System;

class Program
{


    static void Main(string[] args)
    {

        Console.Clear();
        LoadingAnimation(100, 400);

        Console.Clear();
        Console.WriteLine("Welcome to Goals' Game!");
        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();

        GoalsManager goalsManager = new GoalsManager(playerName);
        Console.Clear();
        goalsManager.WelcomeUserAnimation();
        goalsManager.WelcomeIntroductionAnimation();

        int option = 0;
        while (option != 7)
        {

            Console.WriteLine($"Player: {goalsManager.GetPlayerName()}");
            Console.WriteLine($"Points: {goalsManager.GetPlayerPoints()}");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Remove a Goal");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Record Event");
            Console.WriteLine("7. Quit");
            Console.WriteLine("0. Introduction");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Player: {goalsManager.GetPlayerName()}");
            Console.WriteLine($"Points: {goalsManager.GetPlayerPoints()}");
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine("The types of goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.WriteLine();
                    Console.Write("Which type of goal would you like to create? ");
                    int choice = int.Parse(Console.ReadLine());
                    goalsManager.CreateGoal(choice);
                    goalsManager.Animation(2, 3);
                    Console.Clear();
                    break;
                case 2:
                    goalsManager.RemoveGoal();
                    Console.WriteLine();
                    goalsManager.Animation(2, 3);
                    Console.Clear();
                    break;
                case 3:
                    goalsManager.ListGoalFull();
                    Console.WriteLine();
                    break;
                case 4:
                    goalsManager.Export();
                    LoadingAnimation(25, 75);
                    Console.WriteLine("\nYour goals have been saved!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 5:
                    goalsManager.Import();
                    LoadingAnimation(40, 100);
                    Console.WriteLine("\nYour goals have been loaded!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    break;
                case 6:
                    goalsManager.RecordEvent();
                    goalsManager.Animation(3, 3);
                    Console.Clear();
                    break;
                case 0:
                    Console.Clear();
                    goalsManager.WelcomeIntroductionAnimation();
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Exiting the program...");
                    break;
            }
        }
    }

    static void LoadingAnimation(int delaMmin, int delayMax)
    {
        string[] loading = {
"Loading: [          00%          ]",
"Loading: [-         03%          ]",
"Loading: [=-        07%          ]",
"Loading: [=         10%          ]",
"Loading: [==-       14%          ]",
"Loading: [===-      18%          ]",
"Loading: [====      20%          ]",
"Loading: [=====-    26%          ]",
"Loading: [=====-    29%          ]",
"Loading: [======    30%          ]",
"Loading: [======-   34%          ]",
"Loading: [=======-  38%          ]",
"Loading: [========  40%          ]",
"Loading: [========- 46%          ]",
"Loading: [========- 49%          ]",
"Loading: [==========50%          ]",
"Loading: [==========58%-         ]",
"Loading: [==========60%==        ]",
"Loading: [==========61%==-       ]",
"Loading: [==========70%====      ]",
"Loading: [==========76%====-     ]",
"Loading: [==========79%=====-    ]",
"Loading: [==========80%======    ]",
"Loading: [==========88%=======-  ]",
"Loading: [==========90%========  ]",
"Loading: [==========96%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========99%=========-]",
"Loading: [==========100%==========]",
"Loading: [==========100%==========]",
"Loading: [==========100%==========]"
};
        Console.CursorVisible = false;
        Random random = new Random();
        foreach (string i in loading)
        {
            Console.Write(i);
            Thread.Sleep((random.Next(delaMmin, delayMax)));

            for (int j = 0; j < i.Length; j++)
            {
                Console.Write("\b");
            }
        }
        Console.CursorVisible = true;

    }

}
