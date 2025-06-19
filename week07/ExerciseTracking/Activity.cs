public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate() => _date;
    public int GetMinutes() => _minutes;

    public abstract double GetDistance(); // in km
    public abstract double GetSpeed();    // km/h
    public abstract double GetPace();     // min/km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}