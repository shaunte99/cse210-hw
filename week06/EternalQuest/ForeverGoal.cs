public class ForeverGoal : UbuntuGoal
{
    public ForeverGoal(string name, int points)
    {
        GoalName = name;
        GoalPoints = points;
    }

    public override int LogProgress() => GoalPoints;

    public override string DisplayStatus() => $"♾️ Always Hustling - {GoalName}";

    public override string SaveGoal() => $"Forever:{GoalName},{GoalPoints}";
}
