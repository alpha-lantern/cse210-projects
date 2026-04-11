public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {}

    public override void RecordEvent()
    { }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        // provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        string stringRepresentation = $"EternalGoal::{GetName()}~{GetDescription()}~{GetPoints()}";
        return stringRepresentation;
    }
}