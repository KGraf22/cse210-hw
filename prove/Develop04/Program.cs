using System;
using System.Collections.Generic;
abstract class MindfulnessActivity
{
    private string _name;            
    private string _description;
    private int _duration;

    public MindfulnessActivity( string name, string description, int duration)
    {

    }
    
    public void StartActivity()
    {

    }

    public void EndActivity()
    {

    }

public class BreathingActivity: MindfulnessActivity
{
    public BreathingActivity()
    {

    }
    public void Run()
    {

    }
}

public class ListingActivity : MindfulnessActivity
{
    private int _count;
    private List<string> _prompts;
    

    public ListingActivity()
    {

    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {

    }
}

public class ReflectingAtivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {

    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {

    }

    public string GetRandomQuestion()
    {

    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}
    

class Program
{
    static void Main(string[] args)
    {

    }
}