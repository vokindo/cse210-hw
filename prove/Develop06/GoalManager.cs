using System;
using System.Collections.Generic;
using System.IO;

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
        // Placeholder for main menu loop logic.
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goal List:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist):");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points:");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (type)
        {
            case "Simple":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "Eternal":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "Checklist":
                Console.WriteLine("Enter target number:");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus points:");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();
            _score += selectedGoal.Points; // Use Points property to access points in a safe way
            Console.WriteLine("Event recorded, points awarded.");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    Goal loadedGoal = null;
                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            loadedGoal = new SimpleGoal(name, description, points);
                            ((SimpleGoal)loadedGoal).SetComplete(isComplete);
                            break;
                        case "EternalGoal":
                            loadedGoal = new EternalGoal(name, description, points);
                            break;
                        case "ChecklistGoal":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            loadedGoal = new ChecklistGoal(name, description, points, target, bonus);
                            ((ChecklistGoal)loadedGoal).SetAmountCompleted(amountCompleted);
                            break;
                    }
                    if (loadedGoal != null)
                    {
                        _goals.Add(loadedGoal);
                    }
                }
            }
        }
    }
}