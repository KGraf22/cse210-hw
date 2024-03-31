using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected int _xp;
    protected int _level;    
    
    public Goal(string name, string description, int points, int xp)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _xp = xp;
        _level =1;
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
    public int GetLevel()
    {
        return _level;
    }
    protected void CheckLevelUp()
    {
        int xpThreshold =1000;
        if (_xp >= xpThreshold)
        {
            _level++;
            Console.WriteLine($"Congratulations! You've reach level {_level}!");
        }
    }
}