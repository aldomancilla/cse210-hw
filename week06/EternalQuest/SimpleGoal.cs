class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) 
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent(ref int score)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            score += _points;
            Console.WriteLine($"Congratulations! You earned {_points} points!");
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
        }
    }

    public override string GetStatus()
    {
        return $"[{( _isComplete ? "X" : " ")}] {_name} ({_description})";
    }

    public override string Serialize()
    {
        return $"SimpleGoal,{_name},{_description},{_points},{_isComplete}";
    }
}