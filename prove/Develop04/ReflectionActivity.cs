using System;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int durationInSeconds) : base(name, description, durationInSeconds)
    {
    }

    public void RunActivity()
    {
        Random rand = new Random();

        Console.WriteLine($"Prompt: {prompts[rand.Next(prompts.Length)]}");

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            PauseSpinner();
        }
    }
}