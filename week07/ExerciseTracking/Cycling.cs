public class Cycling : Activity
{
    private double _speed;

    public Cycling(string name, double length, double speed) : base (name, length)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * GetLength() / 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}