using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        do{
            //Menu//
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Sart breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter the duration of the breathing activity (in seconds): ");
                int durationInSeconds = int.Parse(Console.ReadLine());
            
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", durationInSeconds);
                breathingActivity.StartMessage();
                Console.Clear();
            
                breathingActivity.PauseSpinner();
                breathingActivity.StartBreathingActivity();
                Console.Clear();
            
                breathingActivity.EndMessage();
            }
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("Enter the duration of the reflection activity (in seconds): ");
                int durationInSeconds = int.Parse(Console.ReadLine());

                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on a past experience and learn from it.", durationInSeconds);
                reflectionActivity.StartMessage();
                Console.Clear();

                reflectionActivity.PauseSpinner();
                reflectionActivity.RunActivity();
                Console.Clear();

                reflectionActivity.EndMessage();
            }
            else if (choice == 3)
            {
                Console.Clear();
                Console.WriteLine("Enter the duration of the listing activity (in seconds): ");
                int durationInSeconds = int.Parse(Console.ReadLine());

                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will prompt you with a random question to list items related to it.", durationInSeconds);
                listingActivity.StartMessage();
                Console.Clear();

                listingActivity.PauseSpinner();
                listingActivity.RunActivity();
                Console.Clear();

                listingActivity.EndMessage();
            }
        } while (choice != 4);
    }
}