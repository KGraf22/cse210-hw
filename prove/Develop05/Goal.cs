using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    
    
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }
    public abstract string GetStringRepresentation();
    public abstract int CalculatePoints();
}