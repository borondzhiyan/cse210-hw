using System;
using System.Net.Http.Headers;

public class Address {
    private string _street;
    private string _city;
    public string _state;
    public string _country;
    public bool _isUsa;

    public Address(string street, string city, string state, string country, bool isUsa){
            _street=street;
            _city=city;
            _state=state;
            _country=country;
            _isUsa=isUsa;
    }

public bool isUsa(){
        return _isUsa;   
}
public string GetAddress(){
    return $"Street: {_street}\nCity: {_city}\nState: {_state}\nCountry: {_country}\nFrom USA: {_isUsa}";
}
}

