using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = 0;

        Console.WriteLine("Enter a list of nonzero numbers, enter 0 when finished.");
        do
        {
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());
            numbers.Add(number);
        } while (number != 0);

        float sum = 0;
        foreach (float n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find largest number in list, using the first number for initial comparison
        float max = numbers[0];
        foreach (float i in numbers)
        {
            if (i >= max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The maximum number is: {max}");

    }
}