//Inheritance with Event Planning:
using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address("123 Main Rd", "Cedar City", "UT", "12348");

        Lecture lectureEvent = new Lecture($"Come Unto Christ", "When you focus your life on Christ, you will be able to find peace and joy.", "May 5, 2024", "6 pm", eventAddress, "Joe Smith", 75);

        OutdoorGathering outdoorGatheringEvent= new OutdoorGathering("Mountain bike race", "Come enjoy some fresh air and the beautiful colors of the Utah mountains.", "May 5, 2024", "10 AM", eventAddress, "65 degrees F");

        Reception receptionEvent = new Reception("Reception of Jack and Jill", "Come and join the happy couple in their marriage","June 11th 2024", "4pm", eventAddress,"Happy@gmail.com", "Gray family");
        
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(outdoorGatheringEvent.GetFullDetails());
        Console.WriteLine(outdoorGatheringEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Message for Marketing");
        Console.WriteLine("Reception:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();


    }
}