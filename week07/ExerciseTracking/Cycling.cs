public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime today, int minutes, double speed, double weight) : base(today, minutes, weight)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Math.Round(GetMinutes() / GetPace(), 2);
    }

    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
    public override double GetCalories()
    {
        return Math.Round(7.5 * GetWeight() * (GetMinutes() / 60.0), 2);
    }
}