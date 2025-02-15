using System;
public abstract class UbuntuGoal
{
    public string GoalName { get; set; }
    public int GoalPoints { get; protected set; }
    public abstract int LogProgress();
    public abstract string DisplayStatus();
    public abstract string SaveGoal();
}


     