using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / Minutes) * 60;
    public override double GetPace() => Minutes / _distance;

    public override string GetSummary()
    {
        return base.GetSummary() + "\nBra, you smashed that run like a true Mzansi champ!";
    }
}
