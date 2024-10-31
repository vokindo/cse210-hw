using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    protected Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance()}, Speed: {GetSpeed()}, Pace: {GetPace()}";
    }
}
