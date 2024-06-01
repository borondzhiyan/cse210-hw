using System;

public class Product{

    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    public Product(string name, int productID, float price, int quantitiy){
        _name=name;
        _productId=productID;
        _price=price;
        _quantity=quantitiy;
    }

    public float GetTotalCost(){
        float total = _price*_quantity;
        return total;         
        }
}

