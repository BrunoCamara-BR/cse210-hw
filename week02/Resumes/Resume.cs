using System.Data;
using System.Security.Cryptography.X509Certificates;


public class Resume
{
    public String _name;
    public List<Jobs> _jobs = new List<Jobs>();

    public void Display()
    {
        List<String> totalJobs = new List<String>();


        foreach (Jobs j in _jobs)
        {
            totalJobs.Add(j._jobTitle);
        }

        Console.WriteLine($"{_name}\n{String.Join(" ",totalJobs)}");

    }

}
