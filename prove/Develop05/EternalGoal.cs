
class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points) : base(title,description,points){}
    override public void Display()
    {
        Console.WriteLine($"[∞] {_title} ({_description})");
    }
    override public string GetSaveString()
    {
        return $"EternalGoal:{_title},{_description},{_points}";
    }
    public override int Complete()
    {
         return _points;
    }
}