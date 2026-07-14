abstract class Activity
{
    protected string _activity="";
    protected string _date;
    protected int _duration=0;
    protected double _distance=0;
    protected double _speed=0;
    protected double _pace=0;
    public Activity(string date,int duration)
    {
        _date=date;
        _duration=duration;
    }
    public string GetDate()
    {
        return _date;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace {GetPace():F2} min per mile\n"; 
        }
}