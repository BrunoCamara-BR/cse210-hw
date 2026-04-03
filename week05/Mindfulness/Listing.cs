using System.Formats.Asn1;

public class Listing : ExerciseBase
{

    private List<string> _reflectPrompts = new List<string>();
    // private List<int> _availablePrompts = new List<int>();

    int _CompletedPromptNumber = 0;

    public Listing(string name, string description) : base(name, description)
    {

    }

    public void AddReflectPrompt(string prompt)
    {
        _reflectPrompts.Add(prompt);
    }

    public void ListingExercise()
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Random random = new Random();
        int index = random.Next(_reflectPrompts.Count);
        Console.WriteLine($"--- {_reflectPrompts[index]} ---");
        Console.WriteLine("You may begin in:");
        base.Countdown(5000);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        _CompletedPromptNumber = 0;
        string answer;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            answer = Console.ReadLine();
            if (answer != "")
            {
                _CompletedPromptNumber++;
            }
            else
            {
                Console.WriteLine("(Empty line)");
            }
        }

        Console.WriteLine($"You listed {_CompletedPromptNumber} items!");
    }

}