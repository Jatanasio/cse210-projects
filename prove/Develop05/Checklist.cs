public class Checklist : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public Checklist(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public Checklist(string name, int points, int targetCount, int bonusPoints, int currentCount) : base(name, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                return _points + _bonusPoints;
            }
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_currentCount == _targetCount ? "X" : " ")}] {_name} - {_points} points (Completed {_currentCount}/{_targetCount} times)";
    }

    public override string Serialize()
    {
        return $"Checklist Goal,{_name},{_points},{_targetCount},{_bonusPoints},{_currentCount}";
    }
}