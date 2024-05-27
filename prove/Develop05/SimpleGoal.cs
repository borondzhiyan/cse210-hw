using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;//false по умолчанию 

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public SimpleGoal(string name, string description, int points, bool IsComplete) : base(name, description, points){
        _isComplete=IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortname()},{base.GetDescription()},{base.GetPoints()},{_isComplete}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base.GetPoints();

    }
}
