using System;


public class Reception : Event
{
    private string _rsvpEmail;
    private string _hostName;
    public Reception( string title, string description, string date, string time, Address address, string rsvpEmail, string hostName) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
        _hostName = hostName;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP Email: {_rsvpEmail}\nHost: {_hostName}";
    }

    public override string GetShortDescription()
    {
        return $"Reception- {_title}-{_date}";
    }
    public override string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}\nHost: {_hostName}";
    }
}
