using System;
using System.Threading;
namespace MindfulnessAppMzansi
{
    class BreathingActivity : MindfulnessActivity
    {
        public override void PerformActivity()
        {
            StartActivity("Breathing", "This activity will help you relax Focus on your Breathing. Lekker vibes!");

            for (int i = 0; i < Duration / 6; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowCountdown(3);
                Console.WriteLine("Breathe out...");
                ShowCountdown(3);
            }
            EndActivity("Breathing");
        }
        private void ShowCountdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b ");
            }
            Console.WriteLine();
        }
    }
}
