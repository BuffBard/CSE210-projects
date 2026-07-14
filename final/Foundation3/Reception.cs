class Reception : Event
{
    private string _email;
    public Reception(string events,string title,string desc,string date,string time,Address address,string email) : base(events,title,desc,date,time,address)
    {
        _email=email;
    }
    override public string FullDetails()
    {
        return $"{_title}, {_desc} | {_date}, {_time}\n{_email}\n{_address.GetFullAddress()}\n";
    }
}