using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(
        string name = "Breathing Activity",
        string description = "This activity will help you relax by instructing you to breath in and out slowly. Clear your mind and focus on your breathing.",
        int duration = 60
        )
    : base(name, description, duration) { }

    public void Run()
    {
        DisplayStartingMessage(); // starting message clears console

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Breathe out...");
            ShowCountDown(7);
        }
        DisplayEndingMessage();
    }
}