public abstract class Goal {
    private string _shortName;
    private string _description;
    private string _points;
    
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    protected string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    protected void SetPoints(int points)
    {
        _points = $"{points}";
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        string detailString = $"{GetCheckbox()} {_shortName} ({_description})";
        return detailString;
    }
    public abstract string GetStringRepresentation();

    protected string GetCheckbox()
    {
        string box = "[ ]";
        if (IsComplete())
        {
            box = "[X]";
        }

        return box;
    }
}