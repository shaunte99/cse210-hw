public class HustleListGoal : UbuntuGoal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public HustleListGoal(string name, int points, int target, int bonusPoints)
    {
        GoalName = name;
        GoalPoints = points;
        targetCount = target;
        bonus = bonusPoints;
        currentCount = 0;
    }

    public override int LogProgress()
    {
        currentCount++;
        return (currentCount == targetCount) ? GoalPoints + bonus : GoalPoints;
    }

    public override string DisplayStatus() => $"📋 Hustle: {GoalName} ({currentCount}/{targetCount})";

    public override string SaveGoal() => $"HustleList:{GoalName},{GoalPoints},{targetCount},{currentCount},{bonus}";
}
