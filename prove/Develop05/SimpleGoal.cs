using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;    
    }
    public override void RecordEvent()
    {
        _isComplete = true;
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