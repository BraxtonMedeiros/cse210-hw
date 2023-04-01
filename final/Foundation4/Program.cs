class Program
    {
        static void Main(string[] args)
        {
            // create some activities
            Running running = new Running(DateTime.Now, 30, 3.0);
            Cycling cycling = new Cycling(DateTime.Now, 45, 12.0);
            Swimming swimming = new Swimming(DateTime.Now, 60, 30);

            // add the activities to a list
            List<Activity> activities = new List<Activity>();
            activities.Add(running);
            activities.Add(cycling);
            activities.Add(swimming);

            // iterate through the activities and display the summaries
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }