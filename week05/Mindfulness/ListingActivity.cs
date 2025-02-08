using System;
using System.Collections.Generic;
namespace MindfulnessAppMzansi
{
    class ListingActivity : MindfulnessActivity
    {
        private readonly List<string> prompts = new List<string>
        {
            "Who are the people in your life that bring you joy, like a summer jol?",
            "What are your favorite things about South Africa's beautiful landscapes?",
            "Which Mzansi dishes make your heart happy?",
            "What moments of kindness have you experienced recently?",
            "Who are your personal heroes from Mzansi?"
        };
        public override void PerformActivity()
        {
            StartActivity("Listing", "This activity will help you reflect on the good things in your life, Mzansi style.");

            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(3);

            List<string> items = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine($"Yebo! You listed {items.Count} items. That's amazing!");
            EndActivity("Listing");
        }
    }
}
