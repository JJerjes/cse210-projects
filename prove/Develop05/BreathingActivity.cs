using System;
using System.Collections.Generic;
using System.Threading;
namespace MindfulnessProgram
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(int duration) : base("Breathing Activity","This activity will help you relax as you breathe in and out slowly.", duration)
        {
        }

        public override void StartActivity()
        {
            base.StartActivity(); 

            for (int i = 0; i < _duration; i++)
            {
                Console.Clear();
                Console.WriteLine("Inhale...");
                ShowCountDown(4); 

                Console.Clear();
                Console.WriteLine("Exhale...");
                ShowCountDown(4); 
            }

            DisplayEndingMessage();  
        }
    }
}