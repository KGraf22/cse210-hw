using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int xp) : base(name, description, points, xp)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;    
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        _xp += 100;
        CheckLevelUp();
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} (Completed: {_amountCompleted}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName}, {_description}, {_points}, {_amountCompleted}/{_target}, {_bonus}";

    }
    public override int CalculatePoints()
    {
        if (_amountCompleted >= _target)
        {
            return _points + _bonus;
        }
        return _amountCompleted * _points;
    }
}