public class OneTimeGoal : UbuntuGoal
{
    private bool achieved;

    public OneTimeGoal(string name, int points)
    {
        GoalName = name;
        GoalPoints = points;
        achieved = false;
    }

    public override int LogProgress()
    {
        if (!achieved)
        {
            achieved = true;
            return GoalPoints;
        }
        return 0;
    }

    public override string DisplayStatus() => achieved ? "✔️ Achieved! - " + GoalName : "⏳ In Progress - " + GoalName;

    public override string SaveGoal() => $"OneTime:{GoalName},{GoalPoints},{achieved}";
}
