using System;
using System.Collections.Generic;

namespace GymActivities
{
    class Swim : Activity
    {   
        private int _laps;
        public Swim(DateTime date, int duration, int laps) : base(date, duration)
        {
            _laps = laps;
        }

        public override double GetDistance() => _laps*50 /1000.0*0.62;
        public override double GetSpeed() => (GetDistance() / Duration) *60;
        public override double GetPace() => Duration / GetDistance();
        public override string GetSummary()
        {
            return base.GetSummary() + $" Swimming: Distance {GetDistance():F2} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min/mile";
        }

    }
}