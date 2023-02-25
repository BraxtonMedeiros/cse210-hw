using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private readonly List<string> prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int durationInSeconds) : base(name, description, durationInSeconds) {}

    public void RunActivity()
    {
        StartMessage();

        string prompt = prompts[new Random().Next(prompts.Count)];
        Console.WriteLine(prompt);

        Countdown(5);

        List<string> items = new();
        string item;

        do
        {
            Console.Write("Enter an item or press Enter to finish: ");
            item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
        } while (!string.IsNullOrEmpty(item));

        Console.WriteLine($"\nYou entered {items.Count} items:");
        foreach (string i in items)
        {
            Console.WriteLine(i);
        }
    }
}
