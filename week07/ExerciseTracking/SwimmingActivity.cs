using System;

public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(string date, int length, int laps) 
    : base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000; // km
    }
    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
}