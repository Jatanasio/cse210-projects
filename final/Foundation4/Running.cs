public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / LengthInMinutes) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(LengthInMinutes / GetDistance(), 2);
    }

    public override string GetSummary()
    {
        return $"{Date.ToShortDateString()} Running ({LengthInMinutes} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
