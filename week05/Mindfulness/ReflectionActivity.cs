using System;
using System.Collections.Generic;

namespace MindfulnessAppMzansi
{
    class ReflectionActivity : MindfulnessActivity
    {
        private readonly List<string> prompts = new List<string>
        {
            "Think of a time when you helped someone during load-shedding.",
            "Remember a moment when you felt the spirit of Ubuntu with your community.",
            "Think of a time when you achieved something despite challenges, like a Mzansi warrior.",
            "Reflect on a memory of a joyful family braai under the stars."
        };

        private readonly List<string> questions = new List<string>
        {
            "What made this experience special to you?",
            "How did it make you feel connected to your roots?",
            "What lessons did you learn from this experience?",
            "How can you carry this positive energy forward?"
        };

        public override void PerformActivity()
        {
            StartActivity("Reflection", "This activity will help you reflect on the beauty and resilience of your Mzansi journey.");

            Random rand = new Random();
            string prompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine(prompt);
            ShowSpinner(3);

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string question = questions[rand.Next(questions.Count)];
                Console.WriteLine(question);
                ShowSpinner(5);
            }

            EndActivity("Reflection");
        }
    }
}
