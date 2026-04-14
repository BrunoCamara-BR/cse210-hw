using System.Runtime.CompilerServices;

public class CheckListGoal : Goal
{
    private int _timesToAccomplish;
    private int _timesDone = 0;
    private int _bonusPoint;

    public CheckListGoal(string name, string descriptionGoal, int points, int timesToAccomplish, int bonusPoint) : base(name, descriptionGoal, points)
    {
        _timesToAccomplish = timesToAccomplish;
        _bonusPoint = bonusPoint;
    }

    public CheckListGoal(string name, string descriptionGoal, int points, int totalPoints, bool isCompleted, int timesToAccomplish, int bonusPoint, int timesDone) : base(name, descriptionGoal, points, totalPoints, isCompleted)
    {
        _timesToAccomplish = timesToAccomplish;
        _bonusPoint = bonusPoint;
        _timesDone = timesDone;
    }

    public int GetTimesDone()
    {
        return _timesDone;
    }
    public void AddAccomplishment()
    {
        _timesDone += 1;
    }

    public void AddBonus()
    {
        Console.WriteLine($"You earned {_bonusPoint} bonus points!");
        base.AddPoints(_bonusPoint);
    }

    public override void AddPoints(int points)
    {

        if (_timesToAccomplish > _timesDone)
        {
            base.AddPoints(points);
            AddAccomplishment();

            if (_timesToAccomplish == _timesDone)
            {
                AddBonus();
                SetIsComplet(true);
            }
        }
    }

    public override string GoalFullDescription()
    {
        return $"{(base.GetIsComplet() ? "[✓]" : "[ ]")} {base.GetName()} ({base.GetDescription()}) — Currently completed: {_timesDone}/{_timesToAccomplish}";
    }

    public override string ExportGoal()
    {
        return $"{GetType()}|{GetName()}|{GetDescription()}|{GetPoints()}|{GetTotalPoints()}|{GetIsComplet()}|{_timesToAccomplish}|{_bonusPoint}|{_timesDone}";
    }
    public void SetIsComplet(bool isComplet)
    {
        _isComplete = isComplet;
    }
}



