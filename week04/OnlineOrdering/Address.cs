public class Address
{

    //Members Variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address() { }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //Members Functions
    public bool IsAtUSA()
    {
        return _country == "USA";
    }

    public string GiveFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }

}