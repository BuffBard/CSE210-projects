class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    public Address(string street, string city, string province, string country)
    {
        _street=street;
        _city=city;
        _province=province;
        _country=country;
    }
    public bool InUSA()
    {
        if (_country=="USA")
        {
            return true;
        }
        else{return false;}
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
    public string GetCountry()
    {
        return _country;
    }
}