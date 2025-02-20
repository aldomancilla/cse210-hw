class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonus = bonus;
    }

    public override void RecordEvent(ref int score)
    {
        _currentCount++;
        score += _points;

        if (_currentCount >= _targetCount)
        {
            score += _bonus;
            Console.WriteLine($"Congratulations! You earned {_points} points and a bonus of {_bonus} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
    }

    public override string GetStatus()
    {
        return $"[{( _currentCount >= _targetCount ? "X" : " ")}] {_name} ({_description}) - Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string Serialize()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_targetCount},{_bonus},{_currentCount}";
    }
}

