using System;
using System.Reflection.PortableExecutable;


public class Event
{
    protected string _title;

    protected string _description;

    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date,string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetFullDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
    public virtual string GetShortDescription()
    {
        return $"Event: {_title}-{_date}";
    }
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }
}






