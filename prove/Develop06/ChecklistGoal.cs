public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            _points += _bonus; // Add bonus points
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString() + $" - Progress: {_amountCompleted}/{_target} - Points: {_points}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}