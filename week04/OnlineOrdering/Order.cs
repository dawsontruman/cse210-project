using System;

public class Order
{
    private string _customer;
    List<Product> _products = new List<Product>();
    public Order(string customer)
    {
        _customer = customer;
    }
    public Order(string customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string[] PackingLabel()
    {
        return [];
    }
    public string ShippingLabel()
    {
        return "";
    }
}