// Polymorphism with Exercise Tracking:
using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        string formattedDateTime = now.ToString("dd MMM yyyy");
        
        List<Activity> activities = new List<Activity>();

        
        activities.Add(new Running(DateTime.Now, 30, 10));
        activities.Add(new Cycling(DateTime.Now, 30, 10.0, 15.0));
        activities.Add(new Swimming(DateTime.Now, 30, 10));
        
        
        Console.WriteLine();
        Console.WriteLine("Here is a Summary of the activies:");

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GenerateSummary(now));
            

        }

       
    }
}