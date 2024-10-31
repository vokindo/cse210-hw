public class Swimming : Activity
{
    private int _laps; // Number of laps

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0); // Distance in kilometers
    }

    public override double GetSpeed()
    {
        double distanceMiles = (_laps * 50 / 1000.0) * 0.62; // Convert to miles
        return (distanceMiles / GetMinutes()) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        double distanceKm = (_laps * 50 / 1000.0); // Distance in km
        return distanceKm > 0 ? GetMinutes() / distanceKm : double.PositiveInfinity; // Pace in min per km
    }

    private int GetMinutes()
    {
        return (int)(this.GetType().GetProperty("Minutes").GetValue(this, null));
    }
}
