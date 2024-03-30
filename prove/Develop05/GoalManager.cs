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
        Console.WriteLine("The type of goals are:");
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
        Console.WriteLine("Creating a new goal...");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Recording an event...");
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