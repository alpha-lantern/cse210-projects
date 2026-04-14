public abstract class Activity
{
    private string _name;
    private double _length;

    public Activity(string name, double length)
    {
        _name = name;
        _length = length;
    }

    // public void SetName(string name)
    // {
    //     _name = name;
    // }
    public double GetLength()
    {
        return _length;
    }
    public string GetDate()
    {
        DateTime today = DateTime.Now;
        return today.ToString("dd MMM yyyy");
    }
    public abstract double GetDistance(); // In km
    public abstract double GetSpeed(); // In Km/h
    public abstract double GetPace(); // In min per km
    public string GetSummary()
    {
        string summary = $"{GetDate()} {_name} ({_length} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
        return summary;
    }
}