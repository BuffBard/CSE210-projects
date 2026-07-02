
class SimpleGoal : Goal
{
    public SimpleGoal(string title, string description, int points):base(title,description,points){}
    public SimpleGoal(string title, string description, int points, bool completed):base(title, description, points, completed){}
    override public void Display()
    {
        string box = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{box} {_title} ({_description})");
    }
    override public string GetSaveString()
    {
        return $"SimpleGoal:{_title},{_description},{_points},{_completed}";
    }
    public override int Complete()
    {
        if (_completed)
            return 0;

        _completed = true;
        return _points;
    }
}