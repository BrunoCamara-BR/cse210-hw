using System.Runtime.Intrinsics.X86;

public class Breathing : ExerciseBase
{

    public Breathing(string name, string description) : base(name, description)
    {

    }

    public void BreathingExercise()
    {
        // DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int breatheTime = (int)Math.Round(_duration * 0.4);

        // first time start slowly :)
        Console.Write("\nBreathe in...");
        base.Countdown(2000);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        base.Countdown(3000);
        Console.WriteLine();
        Console.WriteLine();

        breatheTime -= 2;

        for (int i = 0; i <= (breatheTime / 4); i++)
        {
            if (breatheTime > 8)
            {
                Console.Write("Breathe in...");
                base.Countdown(4000);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown(6000);
                Console.WriteLine();
                Console.WriteLine();
                breatheTime -= 4;
            }
            else if (breatheTime > 4 && breatheTime < 8)
            {
                // repeat 2 proportional times
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Breathe in...");
                    base.Countdown((breatheTime / 2) * 1000);
                    Console.WriteLine();
                    Console.Write("Now breathe out...");
                    base.Countdown((int)Math.Ceiling((breatheTime / 2) * 1.5 * 1000));
                    Console.WriteLine();
                    Console.WriteLine();
                }
                breatheTime = 0;
            }
            else
            {
                Console.Write("Breathe in...");
                base.Countdown(breatheTime * 1000);
                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.Countdown(((int)Math.Ceiling(breatheTime * 1.5)) * 1000);
                Console.WriteLine();
                breatheTime = 0;
            }
        }

    }
}