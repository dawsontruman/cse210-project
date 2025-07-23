using System;

public class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int length, double distance) 
    : base(date, length)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
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