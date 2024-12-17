using System;
using System.Collections.Generic;

namespace ActivitySix
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus)
            : base(name, description, points)
        {
            _amountCompleted = 0;
            _target = target;
            _bonus = bonus;
        }

        public override void RecordEvent()
        {
            _amountCompleted++;
            Console.WriteLine($"Recorded progress: {_shortName}. Filled {_amountCompleted}/{_target} times.");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"¡Congratulations! You completed '{_shortName}'and you got {_points + _bonus} points.");
            }
            else
            {
                Console.WriteLine($"you won {_points} points.");
            }
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            return $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName}: {_description} " +
                   $"(Progress: {_amountCompleted}/{_target}, Bond: {_bonus} points)";
        }
    }

}

