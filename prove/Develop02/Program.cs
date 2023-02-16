using System;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        while (true)
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.WriteLine("Enter a filename:");
                    var filename = Console.ReadLine();
                    journal.SaveJournal(filename);
                    break;
                case "4":
                    Console.WriteLine("Enter a filename:");
                    filename = Console.ReadLine();
                    journal.LoadJournal(filename);
                    break;
                case "5":
                    return;
            }
        }
    }
}