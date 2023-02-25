using System;
using System.Threading;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration) {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void StartMessage() {
        Console.WriteLine($"Starting {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(5000);
    }

    public void EndMessage() {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(5000);
    }

    protected void Countdown(int seconds) {
        for (int i = seconds; i > 0; i--) {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void PauseSpinner() {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}