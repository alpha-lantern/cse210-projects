public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, string target, string bonus, string amountCompleted) : base(name, description, points)
    {
        _target = int.Parse(target);
        _bonus = int.Parse(bonus);
        _amountCompleted = int.Parse(amountCompleted);
    }

    private void AddBonus()
    {
        int normalPoints = int.Parse(GetPoints());
        SetPoints(normalPoints + _bonus);
    }

    public override void RecordEvent()
    {
        _amountCompleted ++;
        if (IsComplete())
        {
            AddBonus();
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        string detailString = $"{GetCheckbox()} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        return detailString;
    }

    public override string GetStringRepresentation()
    {
        // provide all of the details of a goal in a way that is easy to save to a file, and then load later.
        string stringRepresentation = $"ChecklistGoal::{GetName()}~{GetDescription()}~{GetPoints()}~{_bonus}~{_target}~{_amountCompleted}";
        return stringRepresentation;
    }
}