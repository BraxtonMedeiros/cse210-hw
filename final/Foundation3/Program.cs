using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Anytown", "CA", "12345");

        Lecture lecture = new Lecture("Lecture Title", "Lecture Description", new DateTime(2023, 4, 1), new DateTime(2023, 4, 1, 13, 0, 0), address, "John Smith", 100);
        Reception reception = new Reception("Reception Title", "Reception Description", new DateTime(2023, 4, 2), new DateTime(2023, 4, 2, 18, 0, 0), address, "rsvp@example.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Outdoor Gathering Title", "Outdoor Gathering Description", new DateTime(2023, 4, 3), new DateTime(2023, 4, 3, 11, 0, 0), address, "Hiking");

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
    }
}