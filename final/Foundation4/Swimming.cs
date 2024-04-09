using System;

public class Swimming : Activity
{
    private int _laps;
    

    public Swimming(DateTime date, int lengthInMinutes, int laps) 
        : base("Swimming", date, lengthInMinutes)
    {
        _laps = laps;
    }
    public override double CalculateDistance()
    {
        return _laps * 50/ 1000.0;
    }
    public override double CalculateSpeed()
    {
        double distanceKm = CalculateDistance();
        double timeHours = _lengthInMinutes/ 60.0;
        return distanceKm != 0 ? (distanceKm / (timeHours)) : 0 ;
    }
    public override string GenerateSummary(DateTime formattedDateTime)
    {
        double distanceKm = CalculateDistance();
        double speedKph = CalculateSpeed() * 60;
        double paceMinPerKm = distanceKm != 0 ? ((_lengthInMinutes / 60.0)/ distanceKm) : 0;

        return $"{formattedDateTime} Swimming({_lengthInMinutes} min) - Laps: {_laps}, Distance: {distanceKm}km, Speed: {speedKph} km/h, Pace: {paceMinPerKm} min per km";
    }
}