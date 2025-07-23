using System;

public abstract class Activity
{
    protected string _date; // we opt to use a string rather than work with the DateTime class
    protected int _length; // minutes
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    public abstract double GetDistance(); // miles
    public abstract double GetSpeed(); // kph
    public abstract double GetPace(); // min per km
    public virtual string GetSummary()
    {
        // need to format distance and speed to one decimal place, and pace to two decimal places
        return $"{_date} ({_length} min)- Distance {GetDistance():N1} km, Speed: {GetSpeed():N1} kph, Pace: {GetPace():N2} min per km";
    }
}