using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity helps you reflect on times when you have shown strength and resilience.")
    {
    }    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
Console.ReadLine();
Console.WriteLine("\nNow ponder on each of the following questions as they are related to your experience.");
ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

       while (DateTime.Now < endTime)
{
    Console.WriteLine();
    Console.WriteLine(_questions[random.Next(_questions.Count)]);

    Console.WriteLine("\nPress Enter when you have something in mind...");
    Console.ReadLine();
}
        DisplayEndingMessage();
    }
}