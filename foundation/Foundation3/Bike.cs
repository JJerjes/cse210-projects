using System;
using System.Collections.Generic;

namespace GymActivities
{
    class Bike : Activity 
    {
        private double _speed;
        public Bike(DateTime date, int duration, double speed) : base(date, duration)
        {
            _speed = speed;
        }
        public override double GetDistance() => (_speed*Duration);
        public override double GetSpeed() => _speed;
        public override double GetPace() => 60/_speed;
        public override string GetSummary()
        {
            return base.GetSummary() + $" Cycling: Distance {GetDistance():F1} miles, Speed {_speed:F1} mph, Pace: {GetPace():F1} min/mile";
        }

    }
}