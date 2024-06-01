using System;
using System.Net.Http.Headers;

public class Address {
    private string _street;
    private string _city;
    public string state;
    public string _cuntry;
    public bool _usa;

    public List<Address> _addresses;

        public Address(){
            _addresses=new List<Address>{};
        }

public bool isUsa(){
        return _usa;   
}
public string GetAddress(){
    
}
}

