using System;

public class PromptGenerator
{
    // honestly, these prompts were copied from the assignment document and chatGPT
    private List<string> _prompts =
    [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Describe a recent challenge and how you handled it.",
        "What habits are helping me, and which are holding me back?",
        "What relationship in my life needs more attention?",
        "What am I avoiding, and why?"
    ];
    
    public string GetRandomPrompt()
    {
        var random = new Random();
        return _prompts[random.Next(0, _prompts.Count())];
    }
}