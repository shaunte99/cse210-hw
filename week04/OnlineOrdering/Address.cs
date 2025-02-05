public class Address
{
    private string _streetAddress;
    private string _cityName;
    private string _ProvinceName;
    private string _countryName;
    public Address(string street, string city, string Province, string country)
    {
        _streetAddress = street;
        _cityName = city;
        _ProvinceName = Province;
        _countryName = country;
    }
    public bool IsInUS()
    {
        return _countryName.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_cityName}, {_ProvinceName}\n{_countryName}";
    }
}
