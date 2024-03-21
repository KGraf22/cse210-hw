using System;
using System.Collections.Generic;
public abstract class MindfulnessActivity
{
    private string _name;            
    private string _description;
    private int _duration;

    public MindfulnessActivity( string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }
    
    public void StartActivity()
    {
        Console.WriteLine($"Starting{_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin in 3 seconds...");
        System.Threading.Thread.Sleep(3000);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {_name} activity");
        Console.WriteLine($"Activity duration: {_duration} seconds");
        Console.WriteLine("Well done!\n");
        System.Threading.Thread.Sleep(3000);
    }
}
public class BreathingActivity: MindfulnessActivity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {

    }
    public void Run()
    {
        base.StartActivity();

        Console.WriteLine("Breathing in ...");
        System.Threading.Thread.Sleep(3000);

        Console.WriteLine("Breathing out...");
        System.Threading.Thread.Sleep(3000);

        //Need to repeat until duration is reached


        base.EndActivity();
    }
}

public class ListingActivity : MindfulnessActivity
{
    private int _count;
    private List<string> _prompts;
    

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>();
    }
    public void Run()
    {
        base.StartActivity();

        Console.WriteLine("Think about the prompt...");
        System.Threading.Thread.Sleep(3000);

        Console.WriteLine("Start listing items...");

        //Need to allow time for listing until time is up


        Console.WriteLine($"Number of items listed: {_prompts.Count}");
        base.EndActivity();
    }
}

public class ReflectingActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _questions;
    

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
        :base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;

    }
    public void Run()
    {
        base.StartActivity();

        Console.WriteLine("What would you like to do?");
        System.Threading.Thread.Sleep(3000);

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");

        Console.WriteLine("Reflecting on the prompt...");

        foreach (string question in _questions)
        {
            Console.WriteLine($"Question: {question}");
            System.Threading.Thread.Sleep(3000);
        }

        base.EndActivity();

    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    
}
    

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity._name = "Breathing";
        breathingActivity._description = "This activity will guide you through a breathing exercise."
        breathingActivity._duration = 30;

        ListingActivity listingActivity = new ListingActivity();
        listingActivity._name = "Listing";
        listingActivity._description = "This activity will help by helping you reflect on the good things in your life by making a list. Counting your blessings. ";
        listingActivity._duration = 60;

        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity._name = "Reflecting";
        reflectingActivity._description = "This activity will hel you to reflect on times when you were able to succeed through your trials.";
        reflectingActivity._duration = 45;
        reflectingActivity._prompts = new List<string> {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
        reflectingActivity._questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?"};
    }
}