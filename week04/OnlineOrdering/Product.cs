using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _price; // units of cents
    private int _quantity;
    public Product(string productName, string productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public int TotalCost()
    {
        return _price * _quantity;
    }
    public string PackingLabel()
    {
        return $"{_productName}, {_productID}";
    }
}