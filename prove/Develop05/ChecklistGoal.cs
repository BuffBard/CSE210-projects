
class ChecklistGoal : Goal
{
    protected int _iterations;
    protected int _bonusPoints;
    protected int _threshold;
    public ChecklistGoal(string title, string description, int points,int bonusPoints,int threshold) : base(title,description,points)
    {
        _iterations=0;
        _bonusPoints=bonusPoints;
        _threshold=threshold;
    }
    public ChecklistGoal(string title, string description, int points,bool completed,int bonusPoints,int threshold,int iterations) : base(title, description, points, completed)
{
    _iterations=iterations;
    _bonusPoints=bonusPoints;
    _threshold=threshold;
    _completed=completed;
}
    override public void Display()
    {
        string box = _completed ? "[X]" : "[ ]";

        Console.WriteLine(
            $"{box} {_title} ({_description}) -- Completed {_iterations}/{_threshold}");
    }
    override public string GetSaveString()
    {
        return $"SimpleGoal:{_title},{_description},{_points},{_completed},{_bonusPoints},{_threshold},{_iterations}";
    }
    public override int Complete()
    {
        if (_completed)
            return 0;

        _iterations++;

        if (_iterations >= _threshold)
        {
            _completed = true;
            return _points + _bonusPoints;
        }

        return _points;
    }
}