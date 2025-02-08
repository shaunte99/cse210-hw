using System;
using System.Threading;

namespace MindfulnessAppMzansi
{
    class MindfulnessMenu
    {
        public void DisplayMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Activities Menu (Mzansi Edition):");
                Console.WriteLine("1. Breathing Activity - Take it easy, boet!");
                Console.WriteLine("2. Reflection Activity - Tap into that Ubuntu spirit!");
                Console.WriteLine("3. Listing Activity - Celebrate the lekker things in life!");
                Console.WriteLine("4. Quit - Hamba kahle!");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                MindfulnessActivity activity;
                switch (choice)
                {
                    case "1":
                        activity = new BreathingActivity();
                        break;
                    case "2":
                        activity = new ReflectionActivity();
                        break;
                    case "3":
                        activity = new ListingActivity();
                        break;
                    case "4":
                        Console.WriteLine("Hamba kahle! Stay blessed, Mzansi warrior!");
                        return;
                    default:
                        Console.WriteLine("Hayi bo! Invalid choice. Please try again.");
                        Thread.Sleep(2000);
                        continue;
                }
                activity.PerformActivity();
            }
        }
    }
}
