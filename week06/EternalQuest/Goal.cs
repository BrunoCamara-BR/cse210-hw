using System.Dynamic;

public abstract class Goal
{
    private string _name;
    private string _descriptionGoal;
    private int _points;
    private int _totalPoints;
    protected bool _isComplete = false;

    public Goal(string name, string descriptionGoal, int points)
    {
        _name = name;
        _descriptionGoal = descriptionGoal;
        _points = points;
    }

    public Goal(string name, string descriptionGoal, int points, int totalPoints, bool isComplet)
    {
        _name = name;
        _descriptionGoal = descriptionGoal;
        _points = points;
        _totalPoints = totalPoints;
        _isComplete = isComplet;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _descriptionGoal;
    }
    public int GetPoints()
    {
        return _points;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public bool GetIsComplet()
    {
        return _isComplete;
    }

    public virtual void AddPoints(int points)
    {
        _totalPoints += points;
    }

    public virtual string GoalFullDescription()
    {
        return $"{(_isComplete ? "[✓]" : "[ ]")} {_name} ({_descriptionGoal})";
    }

    public virtual string ExportGoal()
    {
        return $"{GetType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTotalPoints()}|{GetIsComplet()}";
    }
}