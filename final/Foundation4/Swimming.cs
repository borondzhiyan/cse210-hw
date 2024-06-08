using System;

public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateOnly date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps*50/1000;
    }

    public override float GetPace()
    {
        return base.GetLength()/GetDistance();
    }

    public override float GetSpeed()
    {
        return 60/GetPace();
    }
}