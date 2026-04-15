public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime today, int minutes, int laps, double weight) : base(today, minutes, weight)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return Math.Round((double)_laps * 50 / 1000, 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(GetDistance() / base.GetMinutes() * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(base.GetMinutes() / GetDistance(), 2);
    }

    public override double GetCalories()
    {
        return Math.Round(6.0 * GetWeight() * (GetMinutes() / 60.0), 2);
    }
}