using System;

class Program
{
    static void Main(string[] args)
    {
        // test square class
        Square testSquare = new Square("red", 1.5);
        Console.WriteLine("Color: " + testSquare.GetColor());
        Console.WriteLine($"Area: {testSquare.GetArea()}");

        // test rectangle class
        Rectangle testRectangle = new Rectangle("blue", 1.5, 2.5);
        Console.WriteLine("Color: " + testRectangle.GetColor()); // should be blue
        Console.WriteLine($"Area: {testRectangle.GetArea()}"); // should be 3.75

        // test circle class
        Circle testCircle = new Circle("green", 3);
        Console.WriteLine("Color: " + testCircle.GetColor());
        Console.WriteLine($"Area: {testCircle.GetArea()}"); // should be ~28.27433388231

        // test with a list, using the same shapes from above
        List<Shape> shapes = [testSquare, testRectangle, testCircle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Color: " + shape.GetColor());
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
        // polymorphism achieved
    }
}