using System;
using System.Collections.Generic;
using System.Threading;
namespace MindfulnessProgram
{
     public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>
        {
            "Who are the people you appreciate?",
            "What are your personal strengths?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity(int duration) : base("Listing Activity", 
                                                   "This activity will help you list good things in your life.",
                                                   duration)
        {
        }

        public override void StartActivity()
        {
            base.StartActivity(); 

            Random random = new Random();
            int timePerPrompt = _duration / prompts.Count;

            foreach (var prompt in prompts)
            {
                Console.Clear();
                Console.WriteLine(prompt);
                ShowCountDown(timePerPrompt);  
            }

            DisplayEndingMessage();  
        }
    }
}