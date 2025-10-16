class Cycling : Activity
{
    private double speed;

    public Cycling(string date, double lengthMinutes, double speed) 
        : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * LengthMinutes) / 60;
    public override double GetSpeed() => speed;
    public override double GetPace() => 60 / speed;
}
