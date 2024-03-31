// added xp to level up
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager("myFile.txt");
        Console.WriteLine("You have 0 points");

        manager.Start();

        bool quit = false;
        while (!quit)
        {   
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(),out int choice))
            {

            
            //int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.CreateGoal();
                        break;

                    case 2:
                        manager.ListGoalNames();
                        break;
                
                    case 3:
                        manager.SaveGoals();
                        break;
               
                    case 4:
                        manager.LoadGoals();
                        break;
               
                    case 5:
                        Console.WriteLine("Record your goal: ");
                        string goalName = Console.ReadLine();
                        manager.RecordEvent(goalName);
                        break;
                
                    case 6:
                        quit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;

                }
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.ReadLine();
            }  

        }
        

        
    }
}