using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager() 
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    
    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    } 

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
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
        
        Console.WriteLine("Enter goal type (1: Simple, 2: Eternal, Checklist): ");
        int type = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        string description = "";
        Console.WriteLine("Enter goal description: ");
        description = Console.ReadLine();

        Console.WriteLine("Enter points for completing the goal: ");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (type)
        {
            case 1: 
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.WriteLine("Enter target count for the checklist goal");
                int target = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter bonus points for completing the checklist goal: ");
                int bonus = Convert.ToInt32(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
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
        Console.WriteLine("Saving goals to a file...");
    }

    public void LoadGoals()
    {
        Console.WriteLine("Loading goals from a file...");
    }
    
       
}