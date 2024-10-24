using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 6; i++) // 6 seconds per breath cycle (3 in, 3 out)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);  // Countdown for 3 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);  // Countdown for 3 seconds
        }

        DisplayEndingMessage();
    }
}
