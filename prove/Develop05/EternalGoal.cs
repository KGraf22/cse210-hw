using System;

public class EternalGoal : Goal
{
    
    public EternalGoal(string name, string description, int points, int xp) : base(name, description, points, xp)
    {
        
    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        // Eternal Goals will not be completed
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}, {_description}, {_points}";        
    }

    public override int CalculatePoints()
    {
        return 0;
    }
}