using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myFractionHmwk = new Assignment("Dawson Truman", "Fractions");
        Console.WriteLine(myFractionHmwk.GetSummary());
        Console.WriteLine();

        MathAssignment myMultiplicationHmwk = new MathAssignment("Dawson Truman", "Multiplication", "Section 4.5", "Problems 2,3,7,11,17");
        Console.WriteLine(myMultiplicationHmwk.GetSummary());
        Console.WriteLine(myMultiplicationHmwk.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment myEssay = new WritingAssignment("Dawson Truman", "Agriculture", "Modern Agricultural Practices");
        Console.WriteLine(myEssay.GetSummary());
        Console.WriteLine(myEssay.GetWritingInformation());
    }
}