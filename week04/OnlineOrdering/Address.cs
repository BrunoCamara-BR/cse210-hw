public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _zip;
    private string _country;

    public Address(string street, string city, string stateProvince, string zip, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _zip = zip;
        _country = country;
    }

    public bool IsInUS()
    {
        return _country == "USA";
    }

    public string FullAddress()
    {
        return $"{_street}\n\t\t{_city}, {_stateProvince} {_zip}\n\t\tCountry:{_country}";
    }
}