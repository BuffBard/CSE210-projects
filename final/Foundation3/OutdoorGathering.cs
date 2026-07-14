class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string events,string title,string desc,string date,string time,Address address,string weather) : base(events,title,desc,date,time,address)
    {
        _weather=weather;
    }
    override public string FullDetails()
    {
        return $"{_title}, {_desc} | {_date}, {_time}\n{_weather}\n{_address.GetFullAddress()}\n";
    }
}