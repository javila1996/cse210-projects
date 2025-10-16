using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime date;
    private double lengthMinutes;

    public Activity(DateTime date, double lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public DateTime Date => date;
    public double LengthMinutes => lengthMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {this.GetType().Name} ({lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}

class Running : Activity
{
    private double distance;

    public Running(DateTime date, double lengthMinutes, double distance) 
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / distance;
}

class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, double lengthMinutes, double speed) 
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * LengthMinutes) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}

class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, double lengthMinutes, int laps) 
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0 * 0.62;
    public override double GetSpeed() => (GetDistance() / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / GetDistance();
}

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>()
        {
            new Running(new DateTime(2022, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2022, 11, 3), 45, 12.0),
            new Swimming(new DateTime(2022, 11, 3), 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
