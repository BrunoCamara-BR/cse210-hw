using System.Runtime.Intrinsics.X86;

public class Breathing : ExerciseBase
{

    public Breathing(string name, string description) : base(name, description)
    {

    }

    public void BreathingExercise()
    {
        // DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int breatheTimeIn = (int)Math.Round(_duration * 0.4);
        int breatheTimeOut = _duration - breatheTimeIn;

        // first time start slowly :)
        Console.Write("\nBreathe in...");
        base.Countdown(2000);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        base.Countdown(3000);
        Console.WriteLine();
        Console.WriteLine();

        breatheTimeIn -= 2;
        breatheTimeOut -= 3;

        for (int i = 0; i <= (breatheTimeIn / 4); i++)
        {
            if (breatheTimeIn > 8)
            {
                Console.Write("Breathe in...");
                base.Countdown(4000);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown(6000);
                Console.WriteLine();
                Console.WriteLine();
                breatheTimeIn -= 4;
                breatheTimeOut -= 6;
            }
            else if (breatheTimeIn > 4 && breatheTimeIn < 8)
            {


                Console.Write("Breathe in...");
                base.Countdown((breatheTimeIn - (breatheTimeIn / 2)) * 1000);
                breatheTimeIn -= breatheTimeIn - (breatheTimeIn / 2);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown((breatheTimeOut - (breatheTimeOut / 2)) * 1000);
                breatheTimeOut -= breatheTimeOut - (breatheTimeOut / 2);
                Console.WriteLine();
                Console.WriteLine();


                Console.Write("Breathe in...");
                base.Countdown((breatheTimeIn * 1000));
                breatheTimeIn = 0;
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown(breatheTimeOut * 1000);
                breatheTimeOut = 0;
                Console.WriteLine();
                Console.WriteLine();


            }
            else
            {
                Console.Write("Breathe in...");
                base.Countdown(breatheTimeIn * 1000);
                breatheTimeIn = 0;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown(breatheTimeOut * 1000);
                breatheTimeOut = 0;
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}