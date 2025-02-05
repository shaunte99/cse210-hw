public class Customer
{
    private string _Name;
    private Address _CustomerAddress;

    public Customer(string Name, Address address)
    {
        _Name = Name;
        _CustomerAddress = address;
    }
       public bool IsInUS()
    {
        return _CustomerAddress.IsInUS();
    }
    public string GetCustomerInfo()
    {
        return $"{_Name}\n{_CustomerAddress.GetFullAddress()}";
    }
    public Address GetCustomerAddress()
    {
        return _CustomerAddress;
    }
}
