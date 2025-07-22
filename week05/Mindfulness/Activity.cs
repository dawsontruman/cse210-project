using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;// 
    protected Random random = new Random();

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        bool validDuration = false;
        while (validDuration == false)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.");
            Console.WriteLine(_description);
            Console.Write("Please enter a duration: ");
            try
            {
                int duration = int.Parse(Console.ReadLine());
                _duration = duration;
                validDuration = true;
            }
            catch (FormatException)
            {
                continue;
            }
        }
        Console.Clear();
        Console.Write("Get ready");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(800);
        }
        Console.Write("\n");
    }
    public void DisplayEndingMessage()
    {
        Console.Write($"This concludes the {_name}.");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = ["|", "/", "-", "\\"];
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string f = spinner[i];
            Console.Write(f);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count())
            {
                i = 0;
            }
        }
        Console.Write("\n");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            if (i < 10)
            {
                Console.Write("\b \b");
            }
            else if (i < 100)
            {
                Console.Write("\b\b  \b\b");
            }
        }
        Console.Write("\n");
    }
}