using System;

public class Activity
{
    protected string _type;
    protected DateTime _date;
    protected int _lengthInMinutes;

    public Activity(string type, DateTime date, int lengthInMinutes)
    {
        _type = type;
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }
    public virtual double CalculateDistance()
    {
        return 0;
    }
    public virtual double CalculateSpeed()
    {
        return 0;
    }
    public virtual string GenerateSummary(DateTime formattedDateTime)
    {
        return $"{formattedDateTime} {_type} ({_lengthInMinutes} min)";
        //return $"{_date}{_type}({_lengthInMinutes} min)";
    }
}