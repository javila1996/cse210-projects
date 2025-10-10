using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }
}
