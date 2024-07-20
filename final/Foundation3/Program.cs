using System;

using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "San Antonio", "TX", "USA");
        Address address2 = new Address("456 Maple Ave", "Tacoma", "WA", "USA");
        Address address3 = new Address("789 Oak Blvd", "Salt Lake", "UT", "USA");

        Event lecture = new Lecture("Engineering Workshop", "Learn how to start a career in engineering", new DateTime(2024, 8, 15), "10:00 AM", address1, "John Doe", 100);
        Event reception = new Reception("Networking Event", "Meet and network with professionals", new DateTime(2024, 8, 20), "6:00 PM", address2, "rsvp@example.com");
        Event outdoorGathering = new OutdoorGathering("Live Music Festival", "Enjoy live music in the park", new DateTime(2024, 9, 10), "12:00 PM", address3, "Sunny with a chance of rain");

        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}