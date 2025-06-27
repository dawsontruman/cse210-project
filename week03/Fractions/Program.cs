using System;

class Program
{
    static void Main(string[] args)
    {
        //test default constructor
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());

        //test whole number constructor
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());

        //test constructor with top and bottom
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());

        //test GetTop
        Console.WriteLine($"{fraction3.GetTop()}");

        //test GetBottom
        Console.WriteLine($"{fraction3.GetBottom()}");

        //test SetTop
        fraction1.SetTop(8);
        Console.WriteLine(fraction1.GetFractionString());

        //test SetBottom
        fraction2.SetBottom(12);
        Console.WriteLine(fraction2.GetFractionString());

        //test GetDecimalValue
        Console.WriteLine($"{fraction1.GetDecimalValue()}");
        Console.WriteLine($"{fraction2.GetDecimalValue()}");
        Console.WriteLine($"{fraction3.GetDecimalValue()}");

    }
}