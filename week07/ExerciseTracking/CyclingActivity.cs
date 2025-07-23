using System;

public class CyclingActivity : Activity
{
    private double _speed; // kph
    public CyclingActivity(string date, int length, double speed) 
    : base(date, length)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * _length;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _length / GetDistance();
    }
}