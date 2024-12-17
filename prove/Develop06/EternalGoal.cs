using System;
using System.Collections.Generic;

namespace ActivitySix
{

    public class EternalGoal : Goal
    {
        public EternalGoal(string name, string description, int points)
            : base(name, description, points)
        {
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"You recorded progress on '{_shortName}' and you got {_points} points.");
        }

        public override bool IsComplete()
        {
            return false; // Nunca se completa
        }

        public override string GetDetailsString()
        {
            return $"[∞] {_shortName}: {_description} (+{_points} points per event)";
        }
    }

}

