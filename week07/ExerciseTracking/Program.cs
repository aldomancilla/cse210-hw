using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 60, 7.2),
            new Cycling(new DateTime(2022, 11, 3), 35, 22.0),
            new Swimming(new DateTime(2022, 11, 3), 45, 33)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}