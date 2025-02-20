using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
    public abstract void RecordEvent(ref int score);
    public abstract string GetStatus();
    public abstract string Serialize();
    
    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split(',');
        string type = parts[0];
        
        if (type == "SimpleGoal") return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
        if (type == "EternalGoal") return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
        if (type == "ChecklistGoal") return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
        
        throw new Exception("Unknown goal type.");
    }
}