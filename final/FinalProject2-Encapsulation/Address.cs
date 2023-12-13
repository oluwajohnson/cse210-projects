public Address
{
    private int _address;
private string _city;
private string _state;
private int _country;

public Address()
{
    _address = "Unknown";
    _city = "Anonymous";
    _state = "Unknown";
    _country = "Unknown";
}

public void InUsa(string address, string city, string state, string country)
{
    _address = address;
    _city = city;
    _state = state;
    _country = country;
    return Console.WriteLine($"Address in USA: address:{_orderCost}, City:{_city}, State:{_state}, Country:{_country}");
}

public void OutsideUsa(string address, string city, string state, string country)
{
    _address = address;
    _city = city;
    _state = state;
    _country = country;
    return Console.WriteLine($"Address outside USA: address:{_orderCost}, City:{_city}, State:{_state}, Country:{_country}");
}

  

}