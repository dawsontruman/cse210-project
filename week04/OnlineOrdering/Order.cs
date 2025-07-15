using System;

public class Order
{
    private Customer _customer;
    List<Product> _products = new List<Product>();
    private int _shippingCost;
    public Order(Customer customer)
    {
        _customer = customer;
        if (customer.InUSA())
        {
            _shippingCost = 500;
        }
        else
        {
            _shippingCost = 3500;
        }
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        if (customer.InUSA())
        {
            _shippingCost = 500;
        }
        else
        {
            _shippingCost = 3500;
        }
    }
    public void AddProduct(Product product, int quantity)
    {
        product.Quantity(quantity);
        _products.Add(product);
    }
    public string PackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.PackingLabelString();
            packingLabel += "\n";
        }
        return packingLabel;
    }
    public string ShippingLabel()
    {
        return _customer.ShippingLabel() + "\n";
    }
    public int OrderCost() // units of cents
    {
        int orderCost = 0;
        foreach (Product product in _products)
        {
            orderCost += product.TotalCost();
        }
        orderCost += _shippingCost;
        return orderCost;
    }
    public string DisplayOrderCost()
    // converts total cost to decimal dollar value and returns a string
    {
        float orderCost = OrderCost();
        float dollarCost = orderCost / 100;
        return $"${dollarCost}\n";
    }
}