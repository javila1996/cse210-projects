using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity", 
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        StartMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4);
            elapsed += 4;

            if (elapsed >= _duration) break;

            Console.WriteLine("Breathe out...");
            Pause(4);
            elapsed += 4;
        }

        EndMessage();
    }
}
