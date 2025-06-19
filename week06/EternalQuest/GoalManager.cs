using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void Start()
    {
        string input;
        do
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": RecordEvent(); break;
                case "4": Console.WriteLine($"Your score: {_score}"); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
            }

        } while (input != "0");
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
        string choice = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (choice == "2")
            _goals.Add(new EternalGoal(name, desc, points));
        else if (choice == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"Earned {earned} points! New score: {_score}");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Save file name: ");
        string file = Console.ReadLine();
        using StreamWriter writer = new(file);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
            writer.WriteLine(goal.GetStringRepresentation());
        Console.WriteLine("Saved.");
    }

    private void LoadGoals()
    {
        Console.Write("Load file name: ");
        string file = Console.ReadLine();
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }
        _goals.Clear();
        var lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    var simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    if (bool.Parse(parts[4])) simple.RecordEvent(); // Mark complete
                    _goals.Add(simple);
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    var checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                    while (checklist.IsComplete() == false && int.Parse(parts[6]) > 0)
                    {
                        checklist.RecordEvent();
                        parts[6] = (int.Parse(parts[6]) - 1).ToString();
                    }
                    _goals.Add(checklist);
                    break;
            }
        }

        Console.WriteLine("Loaded.");
    }
}