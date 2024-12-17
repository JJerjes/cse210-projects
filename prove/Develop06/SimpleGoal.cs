using System;
using System.Collections.Generic;

namespace ActivitySix
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            _isComplete = false;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
            Console.WriteLine($"¡Congratulations! You completed'{_shortName}' and you got {_points} points.");
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override string GetDetailsString()
        {
            return $"[{(_isComplete ? "X" : " ")}] {_shortName}: {_description}";
        }
    }

}
