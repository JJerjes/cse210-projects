using System;
using System.Collections.Generic;
using System.Threading;
namespace MindfulnessProgram
{
    class Program
{
    static void Main(string[] args)
    {
        while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Mindfulness Program");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. List");
                Console.WriteLine("4. quit");
                Console.Write("Select a choice from the menu: ");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 4)
                    break;

                Console.Write("Enter the duration of the activity in seconds: ");
                int duration = int.Parse(Console.ReadLine());

                Activity activity = null;

                switch (opcion)
                {
                    case 1:
                        activity = new BreathingActivity(duration);
                        break;
                    case 2:
                        activity = new ReflectionActivity(duration);
                        break;
                    case 3:
                        activity = new ListingActivity(duration);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        continue;
                }

                activity.StartActivity();
    }
    }
}
}

