abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal(string title, string description, int points)
    {
        _title=title;
        _description=description;
        _points=points;
        _completed=false;
    }
    public Goal(string title, string description, int points, bool completed)
{
    _title = title;
    _description = description;
    _points = points;
    _completed = completed;
}
    abstract public void Display();
    abstract public string GetSaveString();
    abstract public int Complete();
}