public class Cycling : Activity
{
    private double _speed; // Speed in mph

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * GetMinutes(); // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in min per mile
    }

    private int GetMinutes()
    {
        return (int)(this.GetType().GetProperty("Minutes").GetValue(this, null));
    }
}
