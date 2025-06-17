using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string userGrade = Console.ReadLine();
        float grade = float.Parse(userGrade);

        string letterGrade;
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine($"Congratulations! You passed tha class!");
        }
        else
        {
            Console.WriteLine("Your grade is not high enough to pass the class. Try harder next time!");
        }
    }
}