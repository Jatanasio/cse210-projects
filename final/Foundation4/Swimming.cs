public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
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
        return $"{Date.ToShortDateString()} Swimming ({LengthInMinutes} min): " +
               $"Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
