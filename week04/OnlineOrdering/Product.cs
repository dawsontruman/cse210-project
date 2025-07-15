using System;

public class Product
{
    private string _productName;
    private string _productID;
    private int _price; // units of cents
    private int _quantity;
    public Product(string productName, string productID, int price)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = 0;
    }
    public void Quantity(int quantity)
    {
        _quantity = quantity;
    }
    public int TotalCost()
    {
        return _price * _quantity;
    }
    public string PackingLabelString()
    {
        return $"{_productName}, {_productID}";
    }
}