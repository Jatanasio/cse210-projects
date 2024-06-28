public class Daily : Goal
{
    private int _timesRecorded;

    public Daily(string name, int points) : base(name, points)
    {
        _timesRecorded = 0;
    }

    public Daily(string name, int points, int timesRecorded) : base(name, points)
    {
        _timesRecorded = timesRecorded;
    }

    public override int RecordEvent()
    {
        _timesRecorded++;
        return _points;
    }

    public override string GetStatus()
    {
        return $"[ ] {_name} - {_points} points (Recorded {_timesRecorded} times)";
    }

    public override string Serialize()
    {
        return $"Daily Goal,{_name},{_points},{_timesRecorded}";
    }
}