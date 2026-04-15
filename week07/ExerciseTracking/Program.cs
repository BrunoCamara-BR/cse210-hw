// Exceed requirements
// added calories

using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(DateTime.Now, 30, 10, 65);
        Cycling cycling = new Cycling(DateTime.Now, 30, 52.5, 65);
        Swimming swimming = new Swimming(DateTime.Now, 30, 10, 65);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.Clear();

        activities.ForEach(item =>
        {
            Console.WriteLine(item.GetType().Name);
            Console.WriteLine(item.GetSummary());
            Console.WriteLine($"Calories burned: {item.GetCalories()} kcal");
            Console.WriteLine();
        });
    }
}