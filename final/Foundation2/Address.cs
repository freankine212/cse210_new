using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zipcode;
    private string _country;

    public Address(string street, string city, string state, int zipcode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        _country = country;
    }

    public bool isUSA()
    {
        return _country == "USA" ? true : false;
    }

    public string GenerateAddress()
    {
        string address = _street + _city +"," + "\n" + _state + _zipcode + _country;

        return address;
    }
}