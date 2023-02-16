using System;

class PromptGenerator
{
    private List<string> prompts = new List<string>(){
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?"
    };
    public Random random;

    public PromptGenerator()
    {
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        return prompts[random.Next(prompts.Count)];
    }
}