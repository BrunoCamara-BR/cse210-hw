public class EternalGoal : Goal
{
    public EternalGoal(string name, string descriptionGoal, int points) : base(name, descriptionGoal, points)
    {
    }

    public EternalGoal(string name, string descriptionGoal, int points, int totalPoints, bool isComplet) : base(name, descriptionGoal, points, totalPoints, isComplet)
    {
    }


    public override string GoalFullDescription()
    {
        return $"[O] {base.GetName()} ({base.GetDescription()})";
    }
}