using System.Globalization;

public class PromptGenerator
{
    List<String> _prompts;

    Random random = new Random();

    public void AddPrompts(List<String> promptsDefined)
    {
        _prompts = promptsDefined;
    }

    public String Prompt()
    {
        int number = random.Next(0, _prompts.Count);
        return _prompts[number];

    }
}