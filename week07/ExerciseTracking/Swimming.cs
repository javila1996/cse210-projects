class Swimming : Activity
{
    private int laps;

    public Swimming(string date, double lengthMinutes, int laps) 
        : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0 * 0.62;
    public override double GetSpeed() => (GetDistance() / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / GetDistance();
}
