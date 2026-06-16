using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Level: {(_score / 1000) + 1}");
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
{
    Console.WriteLine("\nGoals:");
    Console.WriteLine($"Total goals: {_goals.Count}");

    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals found.");
        return;
    }

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
    }
}
    public void RecordGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();

            _score += earned;

            Console.WriteLine($"You earned {earned} points!");
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4])));
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])));
                    break;

                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[4]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])));
                    break;
            }
        }
    }
}