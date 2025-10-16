using System;

abstract class Activity
{
    private string date;
    private double lengthMinutes;

    public Activity(string date, double lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public string Date => date;
    public double LengthMinutes => lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{date} {this.GetType().Name} ({lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min/mile";
    }
}
