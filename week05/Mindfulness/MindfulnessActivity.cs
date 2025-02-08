using System;
using System.Threading;

namespace MindfulnessAppMzansi
{
    abstract class MindfulnessActivity
    {
        protected int Duration;

        public void StartActivity(string activityName, string description)
        {
            Console.WriteLine($"\nStarting {activityName}: {description}");
            Console.Write("Enter the duration in seconds: ");
            Duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Prepare to begin... Yebo!\n");
            ShowSpinner(3);
        }

        public void EndActivity(string activityName)
        {
            Console.WriteLine($"\nEish! Well done! You've completed the {activityName} for {Duration} seconds.");
            ShowSpinner(3);
        }

        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("|\b");
                Thread.Sleep(250);
                Console.Write("/\b");
                Thread.Sleep(250);
                Console.Write("-\b");
                Thread.Sleep(250);
                Console.Write("\\\b");
                Thread.Sleep(250);
            }
            Console.WriteLine();
        }

        public abstract void PerformActivity();
    }
}
