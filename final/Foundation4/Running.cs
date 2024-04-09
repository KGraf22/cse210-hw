using System;

public class Running: Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance) : base("Running", date, lengthInMinutes)
    {
        _distance = distance;

    }

    public override double CalculateSpeed()
    {
        double distanceMiles = _distance;
        double timeHours= _lengthInMinutes/ 60.0;
        return distanceMiles != 0 ? (distanceMiles / timeHours) : 0;
    }

    public override string GenerateSummary(DateTime formattedDateTime)
    {
        double distanceMiles = _distance;
        double speedMph = CalculateSpeed();
        double paceMinPerMile = speedMph != 0 ? (60/ speedMph) : 0;

        return $"{formattedDateTime} Running({_lengthInMinutes} min) - Distance: {distanceMiles} miles, Speed: {speedMph}mph, Pace: {paceMinPerMile} min per mile";
    }
}