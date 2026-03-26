// Stores a complete address
public class Address(string street, string city, string state, string country)
{
    private string _street = street;
    private string _city = city;
    private string _state = state;
    private string _country = country;

    public bool InUSA()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddressText()
    {
        return $"{_street} {_city}, {_state} - {_country}";
    }
}