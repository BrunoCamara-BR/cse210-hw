using System.Data;


public class Program
{


    static void Main(string[] args)
    {
        Jobs job1 = new Jobs();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2026;

        // job1.Display();

        Jobs job2 = new Jobs();
        job2._company = "Manager";
        job2._jobTitle = "Design";
        job2._startYear = 2016;
        job2._endYear = 2025;

        // job2.Display();

        Resume res1 = new Resume();
        res1._name = "Bruno";
        res1._jobs.Add(job1);
        res1._jobs.Add(job2);

        res1.Display();

    }
}