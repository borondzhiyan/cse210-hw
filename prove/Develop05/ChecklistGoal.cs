using System;
using System.Dynamic;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public CheckListGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted=amountCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetShortname()},{base.GetDescription()},{base.GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;// возвращает резульат сравнения. неправильно - false
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        if (IsComplete()){
            return base.GetPoints()+_bonus;
        }
        return base.GetPoints();
    }

    public override string GetDetailString()
    {

        return base.GetDetailString() + $" - Currently completed: {_amountCompleted}/{_target}";
    }
    public int GetBonus()
    {
        return _bonus;
    }
}