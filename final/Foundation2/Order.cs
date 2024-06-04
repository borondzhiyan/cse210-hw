using System;
using System.Numerics;

public class Order{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer){
        _customer=customer;
        _products =new List<Product>();
    }
    public void AddProduct(Product product){
        // создан новый лист _products и теперь делаем функцию, параметром которой является переменная типа Product, добавляется в лист через Add
        _products.Add(product);
    }

    public float GetTotalPrice(){
        float total=0;
        foreach (Product product in _products){
            total += product.GetTotalCost();
        }
        if (_customer.isFromUsa()){
            total=total+5;
        }
        else{total+=35;}
        return total;
    }

    public string GetPackingLabel(){
        string packinglabel="Packing label:\n";
        foreach (Product product in _products){
            packinglabel+=$"{product.GetName()}: {product.GetProductId()}\n";
        }
        return packinglabel;
    }
    public string GetShippingLabel(){
        return $"Shipping label\n{_customer.GetCustomerName()} - {_customer.GetCustomerAddress()}";

    }

    
 }