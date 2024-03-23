using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Threading;
public abstract class MindfulnessActivity
{
    private string _name;            
    private string _description;
    protected int _duration;

    public MindfulnessActivity( string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }
    
    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} activity...");
        Console.WriteLine(_description);
        Console.WriteLine("Get ready to begin in 3 seconds...");
        DisplayCountdown(3);
    }

    public void EndActivity()
    {
        Console.WriteLine($"Congratulations! You've completed the {_name} activity");
        Console.WriteLine($"Activity duration: {_duration} seconds");
        Thread.Sleep(2000);
        Console.WriteLine("Well done!\n");
        Thread.Sleep(3000);
    }

    protected void DisplayCountdown(int seconds)
    {
        for(int i = seconds; i>0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void DisplayAnimation(int duration)
    {
        for (int i = 0; i<duration; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
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
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)  
        {                                                                    

            Console.WriteLine("Breathe in ...");
            
            DisplayAnimation(4);

            if (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe out...");
                
                DisplayAnimation(5);
            }
    
        }
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

        Console.WriteLine("Make a list of things in your life that you are grateful for.");
        //Thread.Sleep((_duration-5)*1000); 
        
        //Console.WriteLine("Start listing items...");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter your list: ");
            string prompt = Console.ReadLine();
            _prompts.Add(prompt);
        }
        
        
        Console.WriteLine($"Number of items listed: {_prompts.Count}");
        Console.WriteLine("List of prompts: ");
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
        
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

        string randomPrompt = GetRandomPrompt();
        
        Console.WriteLine($"Prompt: {randomPrompt}");
        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();

        }
        //string randomQuestion = GetRandomQuestion();
        //Console.WriteLine($"Question: {randomQuestion}");
        foreach (string question in _questions)
        {
            Console.WriteLine($"Question: {question}");
            Console.ReadLine();
            
        }

        base.EndActivity();

    }
    protected string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
    //protected string GetRandomQuestion();
    //{
    //    Random random= new Random();
    //    int index = random.Next(_questions.Count);
    //    return _questions[index];
    //}
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
        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you to reflect on times when you were able to succeed through your trials.",45, prompts, questions);
        reflectingActivity.Run();
    }

    static void StartListingActivity()
    {
        Console.WriteLine("\nStarting Listing Activity...");
        ListingActivity listingActivity = new ListingActivity("Listing","This activity will help you reflect on the good things in your life by making a list. Counting your blessings.", 45);
        listingActivity.Run();
    }
}   