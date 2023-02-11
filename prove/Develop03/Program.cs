using System;

class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            Scripture scripture = new Scripture(reference, scriptureText);

            while (!scripture.IsFullyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetRenderedText());
                Console.WriteLine("\nPress the enter key or type quit:");
                string userInput = Console.ReadLine();

                if (userInput == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWords();
                }
            }
        }
    }