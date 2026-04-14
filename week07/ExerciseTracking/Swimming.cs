public class Swimming : Activity
{
    private double _laps;

    public Swimming(string name, double length, double laps) : base (name, length)
    {
        _laps = laps;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}