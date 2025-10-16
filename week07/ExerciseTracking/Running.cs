class Running : Activity
{
    private double distance;

    public Running(string date, double lengthMinutes, double distance) 
        : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;
    public override double GetSpeed() => (distance / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / distance;
}
