using System;

public class Customer {
    private string _name;
    private Address _address;
    public Customer(string name, Address address){
    _name=name;
    _address=address;
    }
    public bool isFromUsa(){
        return _address.isUsa();
    }

    public string GetCustomerName(){
        return _name;
    }
    public string GetCustomerAddress(){
        return _address.GetAddress();
    }
}