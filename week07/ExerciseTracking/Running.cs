using System.Runtime.InteropServices;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime today, int minutes, double distance, double weight) : base(today, minutes, weight)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_distance / base.GetMinutes() * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(base.GetMinutes() / _distance, 2);
    }
    public override double GetCalories()
    {
        return Math.Round(8.0 * GetWeight() * (GetMinutes() / 60.0), 2);
    }
}