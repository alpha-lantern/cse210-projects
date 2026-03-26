using System.ComponentModel;

public class Customer(string name)
{
    private string _name = name;
    private Address _address;

    public bool LiveInUSA()
    {
        return _address.InUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Set the customer address
    public void SetAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }
}