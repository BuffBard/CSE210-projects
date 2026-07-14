class Swimming : Activity
{
    private int _lapsNo;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _lapsNo = laps;
    }

    public override double GetDistance()
    {
        return (_lapsNo * 50 / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}