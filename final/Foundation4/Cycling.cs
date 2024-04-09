using System;

public class Cycling : Activity
{
    private double _distance;
    private double _speed;

    public Cycling(DateTime date, int lengthInMinutes, double distance,double speed) : base("Cycling", date, lengthInMinutes)
    {
        _distance = distance;
        _speed = speed;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override string GenerateSummary(DateTime formattedDateTime)
    {
        double distance = CalculateDistance();
        double speed = CalculateSpeed();
        double pace = distance != 0 ?(_lengthInMinutes / distance) : 0; 

        return $"{formattedDateTime} Cycling({_lengthInMinutes} min) - Distance: {distance} miles, Speed: {speed}mph, Pace: {pace} min per mile";
    }
}