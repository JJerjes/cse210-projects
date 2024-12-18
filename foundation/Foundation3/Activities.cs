using System;
using System.Collections.Generic;

namespace GymActivities
{
    abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        protected Activity(DateTime date, int duration)
        {
            this._date = date;
            this._duration = duration;
        }
        public DateTime Date => _date;
        public int Duration => _duration;
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();
        public virtual string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} ({_duration} min):";
        }    
    }
}