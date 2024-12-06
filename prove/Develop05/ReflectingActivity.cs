using System;
using System.Collections.Generic;
using System.Threading;
namespace MindfulnessProgram
{
    public class ReflectionActivity : Activity
    {
        private List<string> questions = new List<string>
        {
            "Think about a time when you stood up for someone else.",
            "Think about a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        public ReflectionActivity(int duration) : base("Reflection Activity", 
                                                       "This activity will help you reflect on moments in which you showed strength.",
                                                       duration)
        {
        }

        public override void StartActivity()
        {
            base.StartActivity();  

            Random random = new Random();
            int timePerQuestion = _duration / questions.Count;

            foreach (var question in questions)
            {
                Console.Clear();
                Console.WriteLine(question);
                ShowCountDown(timePerQuestion);  
            }

            DisplayEndingMessage();  
        }
    }
}