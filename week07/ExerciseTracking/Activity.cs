public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    private double _weight;

    public Activity(DateTime today, int minutes, double weight)
    {
        _date = today;
        _minutes = minutes;
        _weight = weight;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date.Day.ToString("D2")} {_date.ToString("MMM")} {_date.ToString("yyyy")} {GetType().Name} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }

    public double GetWeight()
    {
        return _weight;
    }

    public abstract double GetCalories();
}