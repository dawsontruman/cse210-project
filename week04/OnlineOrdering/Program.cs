using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        // create some products; default quant is 0
        Product twoPercentMilk = new Product("Milk 2%", "002", 429);
        Product coloredPencils24 = new Product("Colored Pencils 24ct", "023", 299);
        Product instantOats64 = new Product("Instant Oats Plain 64oz", "345", 599);

        // create an address
        Address myHome = new Address("903 S Highland Dr.", "Harrisonville", "MO", "United States");
        // create a customer
        Customer myMom = new Customer("Mom", myHome);
        // create the customer's order
        Order momsOrder = new Order(myMom);
        // add products to order, specifying quantity
        momsOrder.AddProduct(twoPercentMilk, 2);
        momsOrder.AddProduct(instantOats64, 1);
        // print total price, packing label, and shipping label
        Console.WriteLine(momsOrder.ShippingLabel());
        Console.WriteLine(momsOrder.PackingLabel());
        Console.WriteLine(momsOrder.DisplayOrderCost());

        // The Canadian Prime Minister needs food storage and pencils. I hope the higher shipping cost isn't a problem ;)
        Address canada = new Address("24 Sussex Dr.", "Ottowa", "Ontario", "Canada");
        Customer markCarney = new Customer("Mark Carney", canada);
        Order canadaOrder = new Order(markCarney);
        canadaOrder.AddProduct(coloredPencils24, 4);
        canadaOrder.AddProduct(instantOats64, 30);
        Console.WriteLine(canadaOrder.ShippingLabel());
        Console.WriteLine(canadaOrder.PackingLabel());
        Console.WriteLine(canadaOrder.DisplayOrderCost());        
    }
}