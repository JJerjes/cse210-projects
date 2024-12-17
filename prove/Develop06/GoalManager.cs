using System;
using System.Collections.Generic;

namespace ActivitySix
{
    public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to the Eternal Search Program");
        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress on a goal");
            Console.WriteLine("3. Show target list");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. quit");
            Console.Write("Select an option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CreateGoal(); break;
                case 2: RecordEvent(); break;
                case 3: ListGoals(); break;
                case 4: DisplayScore(); break;
                case 5: Console.WriteLine("¡See you soon!"); break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select the type of objective:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Target name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points to complete: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("Number of times to complete the objective: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("¡Goal created successfully!");
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        Console.Write("Enter the target number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += _goals[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
    }

    private void ListGoals()
    {
        Console.WriteLine("\nTarget List:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine($"Current score: {_score} points.");
    }
}

}
