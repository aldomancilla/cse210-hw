using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.Write("Enter name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a short description of it: ");
        string desc = Console.ReadLine();
        Console.Write("Enter the amount of points associated with this goal: ");
        int points = int.Parse(Console.ReadLine());
        
        if (choice == 1)
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (choice == 2)
            _goals.Add(new EternalGoal(name, desc, points));
        else if (choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        
        ShowScore();
    }
    
    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
            Console.WriteLine(goal.GetStatus());
    }
    
    public void RecordEvent()
    {
        Console.WriteLine("\nSelect a goal to record: ");
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
            
        int choice = int.Parse(Console.ReadLine()) - 1;
        _goals[choice].RecordEvent(ref _score);
        ShowScore();
        
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filePath = Console.ReadLine();

        List<string> lines = new List<string> { _score.ToString() };
        foreach (var goal in _goals)
            lines.Add(goal.Serialize());

        File.WriteAllLines(filePath, lines);
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            _score = int.Parse(lines[0]);
            _goals.Clear();
            for (int i = 1; i < lines.Length; i++)
                _goals.Add(Goal.Deserialize(lines[i]));
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }
}