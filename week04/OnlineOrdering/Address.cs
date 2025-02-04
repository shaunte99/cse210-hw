public class Address
{
    private string _streetAddress;
    private string _cityName;
    private string _StateName;
    private string _countryName;
    public Address(string street, string city, string province, string country)
    {
        _streetAddress = street;
        _cityName = city;
        _StateName = State;
        _countryName = country;
    }
    public bool IsInUS()
    {
        return _countryName.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_cityName}, {_StateName}\n{_countryName}";
    }
}
