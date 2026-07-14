class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string events,string title,string desc,string date,string time,Address address,string speakerName,int capacity) : base(events,title,desc,date,time,address)
    {
     _speakerName=speakerName;
     _capacity=capacity;   
    }
    override public string FullDetails()
    {
        return $"{_title}, {_desc} | {_date}, {_time}\n{_speakerName}, {_capacity}\n{_address.GetFullAddress()}\n";
    }
}