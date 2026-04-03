public class Reflection : ExerciseBase
{

    private List<string> _startRandomPrompt = new List<string>();
    private List<string> _endRandomPrompt = new List<string>();

    private List<int> _availableEndPrompt = new List<int>();

    public Reflection(string name, string description) : base(name, description)
    {

    }

    public void AddStartPrompts(string prompt)
    {
        _startRandomPrompt.Add(prompt);
    }

    public void AddEndPrompts(string prompt)
    {
        _endRandomPrompt.Add(prompt);
    }

    private void StartRandomReflectionMsg()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Random random = new Random();
        int index = random.Next(_startRandomPrompt.Count);
        Console.WriteLine($"--- {_startRandomPrompt[index]} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.WriteLine();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.Countdown(3000);
    }

    public void ReflectionExercise()
    {
        StartRandomReflectionMsg();

        Console.Clear();
        _availableEndPrompt = Enumerable.Range(0, _endRandomPrompt.Count).ToList();
        Random random = new Random();

        int exerciseTime = _duration;

        for (int i = 0; i < (_duration / 10); i++)
        {
            int index = random.Next(_availableEndPrompt.Count);
            Console.Write(_endRandomPrompt[_availableEndPrompt[index]] + " ");
            _availableEndPrompt.RemoveAt(index);
            if (i + 1 == (_duration / 10))
            {

                // left time;
                base.Animation(2, exerciseTime);
                Console.WriteLine();
            }
            else
            {
                exerciseTime -= 10;
                base.Animation(1, 10);
                Console.WriteLine();
            }
        }

    }

}