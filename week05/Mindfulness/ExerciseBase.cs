using System.Collections;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;

public class ExerciseBase
{
    private string _name = "";
    protected int _duration = 0;

    private string _description = "";


    public ExerciseBase()
    {

    }

    public ExerciseBase(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMsg()
    {
        Console.WriteLine($"Welcome o the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        _duration = 0;
        while (_duration < 10)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            _duration = int.Parse(Console.ReadLine());
            if (_duration < 10)
            {
                Console.WriteLine("For this exercise the minimal time is 10s");
            }
        }
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Animation(1);
    }

    public void LoadingAnimation()
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
            Thread.Sleep((random.Next(100, 900)));

            for (int j = 0; j < i.Length; j++)
            {
                Console.Write("\b");
            }
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

    public void Countdown(int ms)
    {
        int second = ms / 1000;
        Console.CursorVisible = false;
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.CursorVisible = true;
    }

    public void EndMsg()
    {
        Console.WriteLine("\nWell done!");
        Animation(3, 4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Animation(3, 4);
        Console.Clear();
    }
}