public class Customer
{
    private string _name;
    private Address _address;

    //Constructor
    public Customer() { }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Members Functions
    public bool IsLiveAtUSA()
    {
        return _address.IsAtUSA();
    }

    public string GetSippingAddress()
    {
        return _address.GiveFullAddress();
    }

    //Getter and Setter
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

}