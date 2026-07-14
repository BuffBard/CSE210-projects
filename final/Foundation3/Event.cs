abstract class Event
{
    protected string _event;
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string events,string title,string desc,string date,string time,Address address)
    {
        _event=events;
        _title=title;
        _desc=desc;
        _date=date;
        _time=time;
        _address=address;
    }

    public string StandardDetails()
    {
        return $"{_title}, {_desc} | {_date}, {_time}\n{_address.GetFullAddress()}\n";
    }
    abstract public string FullDetails();//Modified Per Event.
    public string ShortDetails()
    {
        return $"{_event}, {_title} | {_date}\n";
    }
}