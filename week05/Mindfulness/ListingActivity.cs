using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = [
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    ]; // copied from assignment document
    public ListingActivity(
        string name = "Listing Activity",
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        int duration = 60,
        int count = 5
        )
    : base(name, description, duration) { }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following:");
        GetRandomPrompt(); // display a random prompt
        Console.WriteLine(); // blank line

        Console.Write("Take a moment to think about the prompt...");
        ShowCountDown(10);

        Console.WriteLine("Enter as many items as you can:");
        List<string> userList = GetListFromUser();

        Console.WriteLine("Time's up!");
        Console.WriteLine($"You entered {userList.Count()} items.");
        Thread.Sleep(2000);
        DisplayEndingMessage();
        Thread.Sleep(2000);
    }
    public void GetRandomPrompt()
    {
        string prompt = _prompts[random.Next(0, _prompts.Count - 1)];
        Console.WriteLine(prompt);
    }
    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration); // needs to be changed to accept the user input duration
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            userList.Add(item);
        }
        return userList;
    }
}