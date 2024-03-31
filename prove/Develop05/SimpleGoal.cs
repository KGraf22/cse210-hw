using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, int xp) : base(name, description, points, xp)
    {
        _isComplete = false;    
    }
    public override void RecordEvent()
    {
        _isComplete = true;
        _xp += 100;
        CheckLevelUp();
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }
    public override int CalculatePoints()
    {
        return _isComplete ? _points : 0;
    }
}