using System;

public class Customer {
    private string _name;
    public List<Customer> _customers;
        public Customer(){
            _customers=new List<Customer>{};
        }


public void AddCustomer(Customer newCustomer){
    _customers.Add(newCustomer);
}
}