using System;
using System.Collections.Generic;

namespace GymActivities
{
    class Running: Activity
    {
        private double _distance;
        public Running(DateTime date, int duration, double distance) : base(date, duration)
        {
            _distance = distance;
        }

        public override double GetDistance() => _distance;
        public override double GetSpeed() => (_distance / Duration) * 60;
        public override double GetPace() => Duration / _distance;
        public override string GetSummary()
        {
            return base.GetSummary() + $" Running: Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
        }
    }
}