using System;
using System.Collections.Generic;

namespace GymActivities
{
    class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
            {
                new Running(new DateTime(2022, 11, 3), 30, 3.0),
                new Bike(new DateTime(2022, 11, 4), 45, 15.0),
                new Swim(new DateTime(2022, 11, 5), 60, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
    }
}
}

