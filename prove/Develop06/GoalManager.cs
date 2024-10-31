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
        // Menu loop logic here
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        // Prompt and create a new goal, add to _goals list
    }

    public void RecordEvent()
    {
        // Select a goal to record event
        // Increase _score based on goal points
    }

    public void SaveGoals()
    {
        // Logic to save _goals to file
    }

    public void LoadGoals()
    {
        // Logic to load _goals from file
    }
}
