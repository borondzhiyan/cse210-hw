
using System;
using System.Net.Http.Headers;

public class Address {
    private string _street;
    private string _city;
    public string _country;


    public Address(string street, string city, string country){
            _street=street;
            _city=city;
            _country=country;

    }
public string GetAddress(){
    return $"Street: {_street}\nCity: {_city}\nCountry: {_country}\n";
}
}

