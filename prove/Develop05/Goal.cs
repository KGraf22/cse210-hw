//RecordEvent() : void (Abstract)
//IsComplete() : bool (Abstract)
//GetDetailsString() : string
//GetStringRepresentation() : string (Abstract)
using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    

    public Goal(string name, string description, int points)
    {

    }
    public abstract void RecordEvent();

    public abstract bool InsComplete();

    public virtual string GetDetailsString()
    {

    }
    public abstract string GetStringRepresentation();
}