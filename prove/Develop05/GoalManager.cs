using System;
using System.IO;
using System.Collections.Generic;



public class GoalManager
{
    private List<Goal> _goals;
    private string _filename;
    private int _score;

    public GoalManager(string filename) 
    {
        _goals = new List<Goal>();
        _score = 0;
        _filename = filename;
    }
    
    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"The goals are:");
        ListGoalNames();
        Console.WriteLine();
        Console.WriteLine($"Current Score: {_score}");
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"Current Level: {goal.GetLevel()}");
        }
        Console.WriteLine();
    } 

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
        }
        else
        {
            foreach (Goal goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
    }
    public void ListGoalTypes()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }            
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("Enter goal type number (1: Simple, 2: Eternal, 3: Checklist): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for completing the goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter XP for the goal: ");
        int xp = Convert.ToInt32(Console.ReadLine());
        switch (type)
        {
            case 1: 
                _goals.Add(new SimpleGoal(name, description, points, xp));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points, xp));
                break;
            case 3:
                Console.WriteLine("Enter target count for the checklist goal");
                int target = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter bonus points for completing the checklist goal: ");
                int bonus = Convert.ToInt32(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, xp));
                break;
            default:
                Console.WriteLine("Invalid goal type. ");
                break;

        }

    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.GetShortName().Equals(goalName))
            {
                goal.RecordEvent();
                _score += goal.CalculatePoints();
                break;
            }
        }
    }

    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved to '{_filename}' successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occured while saving goals: {ex.Message}");
        }
        
    }

    public void LoadGoals()
    {
        try{
            if (File.Exists(_filename))
            {
                using (StreamReader reader = new StreamReader(_filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                    }
                }
                Console.WriteLine($"Goals loaded from '{_filename}' successfully.");
            }
            else
            {
                Console.WriteLine($"File '{_filename}' does not exist. No goals loaded");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error occurred while loading goals: {ex.Message}");

        }
        
    }
    
       
}