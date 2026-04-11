public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, string points, string isComplete) : base(name, description, points)
    {
        _isComplete = bool.Parse(isComplete);
    }

    public override void RecordEvent()
    {
        // Find a way to put an X to mark as completed.
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        // provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        string stringRepresentation = $"SimpleGoal::{GetName()}~{GetDescription()}~{GetPoints()}~{_isComplete}";
        return stringRepresentation;
    }
}