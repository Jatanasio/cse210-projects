using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Activity running = new Running(new DateTime(2024, 11, 3), 30, 6.9);
        Activity cycling = new Cycling(new DateTime(2024, 11, 3), 30, 22.0);
        Activity swimming = new Swimming(new DateTime(2024, 11, 3), 30, 23);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
