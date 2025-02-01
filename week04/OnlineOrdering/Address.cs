public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    public bool IsInUS()
    {
        return _country.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
}
