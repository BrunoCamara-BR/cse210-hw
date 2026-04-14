public class SimpleGloal : Goal
{

    public SimpleGloal(string name, string descriptionGoal, int points) : base(name, descriptionGoal, points)
    {
    }
    public SimpleGloal(string name, string descriptionGoal, int points, int totalPoints, bool isComplet) : base(name, descriptionGoal, points, totalPoints, isComplet)
    {
    }

    public override void AddPoints(int points)
    {
        if (!(_isComplete))
        {
            base.AddPoints(points);
            SetIsComplet(true);
        }
    }
    public void SetIsComplet(bool isComplet)
    {
        _isComplete = isComplet;
    }
}