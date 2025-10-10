using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: DisplayGoals(); break;
                case 3: SaveGoals(); break;
                case 4: LoadGoals(); break;
                case 5: RecordEvent(); break;
                case 6: Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        if (type == 1)
        {
            goal = new SimpleGoal(name, description, points);
        }
        else if (type == 2)
        {
            goal = new EternalGoal(name, description, points);
        }
        else
        {
            Console.Write("Enter how many times to complete this goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for completion: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name, description, points, target, bonus);
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully!");
    }

    private void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        int index = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{index}. {g.GetDetailsString()}");
            index++;
        }
    }

    private void SaveGoals()
    {
        Console.WriteLine("Saving goals (to be implemented)...");
    }

    private void LoadGoals()
    {
        Console.WriteLine("Loading goals (to be implemented)...");
    }

    private void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish?");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("Select a goal number: ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;

        if (goalNum >= 0 && goalNum < _goals.Count)
        {
            int pointsEarned = _goals[goalNum].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
