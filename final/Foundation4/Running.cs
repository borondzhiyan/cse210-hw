using System;

public class Running : Activity {
    private float _distance;

    public Running(DateOnly date, int length, float distance) : base(date, length)
    {
        _distance=distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetPace()
    {
        return base.GetLength()/_distance;
    }

    public override float GetSpeed()
    {
        return _distance/base.GetLength()*60;
    }

    protected override string GetTypeActivity()
    {
        return "Running";
    }
}