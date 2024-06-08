using System;

public class Cycling : Activity
{
    private float _speed;
    public Cycling(DateOnly date, int length, float speed) : base(date, length)
    {
        _speed=speed;
    }

    public override float GetDistance()//методы, которые бли в абстактном классе переопределены здесь
    {
        return _speed*base.GetLength();
    }

    public override float GetPace()
    {
        return 60/_speed;
    }

    public override float GetSpeed()
    {
        return _speed;
    }
}