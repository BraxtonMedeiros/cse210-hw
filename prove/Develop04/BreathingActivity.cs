public class BreathingActivity : Activity {
    private int durationInSeconds;

    public BreathingActivity(string name, string description, int durationInSeconds) : base(name, description, durationInSeconds) {
        this.durationInSeconds = durationInSeconds;
    }

    public void StartBreathingActivity() {
        Console.WriteLine("Starting breathing activity...\n");
        Thread.Sleep(1000);

        Console.WriteLine("Get comfortable and prepare to breathe slowly and deeply.\n");
        Thread.Sleep(3000);

        Console.WriteLine("Take a deep breath in...\n");
        Thread.Sleep(2000);

        int duration = this.durationInSeconds - 3;
        int cycleDuration = 7;
        int cycleCount = duration / cycleDuration;
        int remainingTime = duration % cycleDuration;

        for (int i = 1; i <= cycleCount; i++) {
            Console.WriteLine($"Breathe in ({i}/{cycleCount})...");
            base.Countdown(5);

            Console.WriteLine($"Breathe out ({i}/{cycleCount})...");
            base.Countdown(4);
        }

        if (remainingTime > 0) {
            Console.WriteLine("Breathe in...");
            base.Countdown(remainingTime > 5 ? 5 : remainingTime);

            if (remainingTime > 4) {
                Console.WriteLine("Breathe out...");
                base.Countdown(remainingTime - 4);
            }
        }

        Console.WriteLine("\nBreathing activity complete!");
    }
}