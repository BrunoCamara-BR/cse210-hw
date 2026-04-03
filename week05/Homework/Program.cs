using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Luke", "Math");
        Console.WriteLine(assignment.GetSummary());


        MathAssignment mathAssignment = new MathAssignment("Pedro", "English", "Section", "8-20");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());


        WritingAssignment writingAssignment = new WritingAssignment("Mathew", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}