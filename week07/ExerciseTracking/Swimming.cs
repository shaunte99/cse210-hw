using System;

public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKm = 50.0 / 1000.0;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapLengthKm;
    public override double GetSpeed() => (GetDistance() / Minutes) * 60;
    public override double GetPace() => Minutes / GetDistance();

    public override string GetSummary()
    {
        return base.GetSummary() + "\nAweh! You swam like a dolphin in Durban’s waves!";
    }
}
