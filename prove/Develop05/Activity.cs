using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessProgram
{
    public class Activity
    {
        public string _name;
        public string _description;
        public int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        // Mostrar el mensaje de inicio de la actividad
        public virtual void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"{_name}");
            Console.WriteLine($"{_description}");
            Console.WriteLine("Duration (in seconds): " + _duration);
            Console.WriteLine("Get ready to start...");
            ShowSpinner(3);  
        }

        public virtual void DisplayEndingMessage()
        {
            Console.Clear();
            Console.WriteLine("¡Good job! You have completed the activity.");
            Console.WriteLine($"Duration: {_duration} seconds.");
            ShowCountDown(3); 
        }

        public void ShowSpinner(int seconds)
        {
            string[] spinner = { "/", "-", "\\", "|" };
            int i = 0;
            for (int j = 0; j < seconds; j++)
            {
                Console.Clear();
                Console.WriteLine($"Loading... {spinner[i]}");
                Thread.Sleep(500); 
                i = (i + 1) % spinner.Length; 
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"countdown: {i} seconds.");
                Thread.Sleep(1000);  
            }
        }

        public virtual void StartActivity()
        {
            DisplayStartingMessage();
        }

        public void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"Pause... {i} seconds left.");
                Thread.Sleep(1000);
            }
        }
    }
}