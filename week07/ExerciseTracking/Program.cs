using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Parse("2025-02-15"), 30, 5.0),
            new Cycling(DateTime.Parse("2025-02-14"), 45, 20.0),
            new Swimming(DateTime.Parse("2025-02-13"), 60, 40)
        };

        Console.WriteLine("** Mzansi Fitness Tracker - Powered by Kamogelo Shaun Matsetela **\n");
        
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(new string('-', 60));
        }

      Console.WriteLine("\nHamba kahle! Keep fit and stay lekker!");
    }
}
