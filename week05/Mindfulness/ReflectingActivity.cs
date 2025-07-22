using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        ]; // copied from assignment document
    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        ]; // copied from assignment document
    public ReflectingActivity(
        string name = "Reflecting Activity",
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        int duration = 60)
    : base(name, description, duration) { }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return _prompts[random.Next(0,_prompts.Count()-1)];
    }
    public string GetRandomQuestion()
    {
        return _questions[random.Next(0,_questions.Count()-1)];
    }
    public void DisplayPrompt()
    {
        Console.Write(GetRandomPrompt());
        ShowSpinner(5);
    }
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write(GetRandomQuestion());
            ShowSpinner(5);
        }
    }
}