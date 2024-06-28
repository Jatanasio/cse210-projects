public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public Simple(string name, int points, bool isComplete) : base(name, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} - {_points} points";
    }

    public override string Serialize()
    {
        return $"Simple Goal,{_name},{_points},{_isComplete}";
    }
}

