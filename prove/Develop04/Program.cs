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
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("\nPlease choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice;
            while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }
            switch (choice)
            {
                case 1:
                    StartBreathingActivity();
                    break;
                case 2:
                    StartReflectionActivity();
                    break;
                case 3:
                    StartListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return;


            }
        }    
    }
    static void StartBreathingActivity()
    {
        Console.WriteLine("\nStarting Breathing Activity...");
        BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will guide you through a breathing exercise.",30);
        breathingActivity.Run();
    }

    static void StartReflectionActivity()
    {
        Console.WriteLine("\nStarting Reflection Activity...");
        List<string> prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        List<string> questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?" };
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will hel you to reflect on times when you were able to succeed through your trials.",45, prompts, questions);
        reflectingActivity.Run();
    }

    static void StartListingActivity()
    {
        Console.WriteLine("\nStarting Listing Activity...");
        ListingActivity listingActivity = new ListingActivity("Listing","This activity will help by helping you reflect on the good things in your life by making a list. Counting your blessings.", 60);
        listingActivity.Run();
    }
}   