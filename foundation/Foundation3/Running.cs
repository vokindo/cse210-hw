public class Running : Activity
{
    private double _distance; // Distance in miles

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return GetMinutes() / _distance; // Pace in min per mile
    }

    private int GetMinutes()
    {
        return (int)(this.GetType().GetProperty("Minutes").GetValue(this, null));
    }
}
