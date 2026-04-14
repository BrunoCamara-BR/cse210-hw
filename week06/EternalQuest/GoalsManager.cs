using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
public class GoalsManager
{
    private string _playerName;
    List<Goal> _goals = new List<Goal>();
    string _fileName;
    int _playerTotalPoints;

    public GoalsManager(string playerName)
    {
        _playerName = playerName;
    }

    public string GetPlayerName()
    {
        return _playerName;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    private void ListGoal()
    {
        int index = 0;
        _goals.ForEach(item =>
        {
            index++;
            Console.WriteLine($" {index}. {item.GetName()}");
        });
    }

    public void RecordEvent()
    {
        ListGoal();
        Console.Write("Which goal number did you accomplish? ");
        int option = int.Parse(Console.ReadLine()) - 1;

        _goals[option].AddPoints(_goals[option].GetPoints());

        UpdatePlayerPoints();
    }

    public void RemoveGoal()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found. Please add goals first.");
        }
        else
        {
            ListGoal();
            Console.Write("Which number of goal to remove? ");
            int option = int.Parse(Console.ReadLine()) - 1;

            _goals.RemoveAt(option);
            UpdatePlayerPoints();
        }
    }

    public void ListGoalFull()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found. Please add goals first.");
        }
        else
        {
            _goals.ForEach(item =>
            {
                Console.WriteLine(item.GoalFullDescription());
            });
        }

    }

    private void FileName()
    {
        Console.Write("Enter the filename for the goal file (example: File.txt): ");
        _fileName = Console.ReadLine();
    }

    public void Export()
    {
        FileName();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_playerName}|{_playerTotalPoints}");
            _goals.ForEach(item =>
            {
                outputFile.WriteLine($"{item.ExportGoal()}");
            });

        }
    }
    public void Import()
    {
        FileName();

        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts[0] == "CheckListGoal")
            {
                AddGoal(new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8])));
            }
            else if (parts[0] == "EternalGoal")
            {
                AddGoal(new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), false));
            }
            else if (parts[0] == "SimpleGloal")
            {
                AddGoal(new SimpleGloal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), bool.Parse(parts[5])));
            }
            else
            {
                _playerName = parts[0];
                _playerTotalPoints = int.Parse(parts[1]);
            }
        }

    }
    public void UpdatePlayerPoints()
    {
        int total = 0;
        _goals.ForEach(item =>
        {
            total += item.GetTotalPoints();
        });
        _playerTotalPoints = total;
    }

    public int GetPlayerPoints()
    {
        return _playerTotalPoints;
    }

    public void CreateGoal(int type = 1)
    {
        if (type == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times must this goal be completed to earn a bonus? ");
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for completing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal checkListGoal = new CheckListGoal(name, description, points, times, bonus);

            AddGoal(checkListGoal);
        }
        else if (type == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(name, description, points);

            AddGoal(eternalGoal);
        }
        else if (type == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("How many points is this goal worth? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGloal simpleGloal = new SimpleGloal(name, description, points);

            AddGoal(simpleGloal);
        }
    }

    private void TypingAnimation(string input, int minDelay, int maxDelay)
    {
        string text = input;

        Random random = new Random();

        for (int i = 0; i < text.Length; i++)
        {
            Thread.Sleep(random.Next(minDelay, maxDelay));
            Console.Write(text[i]);
        }
    }

    private void ErasingAnimation(string input, int minDelay, int maxDelay)
    {
        string text = input;

        Random random = new Random();

        for (int i = 0; i < text.Length; i++)
        {
            Thread.Sleep(random.Next(minDelay, maxDelay));
            Console.Write("\b \b");
        }
    }

    public void WelcomeUserAnimation()
    {
        string msg;
        Console.CursorVisible = false;
        msg = $"Welcome, {_playerName}! :D";
        TypingAnimation(msg, 100, 250);
        Thread.Sleep(1000);
        ErasingAnimation(msg, 50, 100);
        Console.CursorVisible = true;
    }


    public void WelcomeIntroductionAnimation()
    {

        Console.CursorVisible = false;

        TypingAnimation("INTRODUCTION\n\n", 100, 150);


        string[] msgs = {
"Welcome to the Goals Game!\n\nIn this game, you will create personal goals and record your progress to earn points. Stay consistent and challenge yourself!",

"The main menu contains the following options:\n\n1. Create New Goal\n2. Remove a Goal\n3. List Goals\n4. Save Goals\n5. Load Goals\n6. Record Event\n7. Quit\n",

"1. Create New Goal\n\nUse this option to create a new goal. You can choose from three types:\n\n1 - Simple Goal: Complete it once to earn points.\n2 - Eternal Goal: This goal never ends; you can earn points every time you record it.\n3 - Checklist Goal: Complete it multiple times to earn points, plus a bonus when finished.",

"2. Remove a Goal\n\nUse this option to delete a goal you no longer want to track.",

"3. List Goals\n\nDisplays all your goals along with their descriptions and current progress.",

"4. Save Goals\n\nSave your current goals and progress to a file. Enter a .txt filename when prompted.",

"5. Load Goals\n\nLoad previously saved goals and progress from a file. Enter the .txt filename to continue.",

"6. Record Event\n\nRecord the completion of a goal to earn points and update your progress.",

"7. Quit\n\nExit the application.",

"0. Tutorial\n\nView this tutorial again at any time."
};

        foreach (string msg in msgs)
        {
            Console.Clear();
            Console.WriteLine("INTRODUCTION\n\n");
            TypingAnimation(msg, 5, 10);
            Animation(1, 5);
            Console.Clear();
        }
        Console.CursorVisible = true;
    }

    public void Animation(int animationType, int seconds = 3)
    {

        Console.CursorVisible = false;
        // Set the seconds time
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        string[] spin;
        switch (animationType)
        {
            case 1:
                spin = new[] { "|", "/", "—", "\\" };
                break;
            case 2:
                spin = new[] { ".", "o", "O", "o" };
                break;
            case 3:
                spin = new[] { "B", "Y", "U", "!" };
                break;
            default:
                spin = new[] { "|", "/", "—", "\\" };
                break;
        }

        int index = 0;
        while (DateTime.Now < endTime)
        {
            if (index == 4) index = 0;
            Console.Write(spin[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            index++;
        }
        Console.CursorVisible = true;
    }

}