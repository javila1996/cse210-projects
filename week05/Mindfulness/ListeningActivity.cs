using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand = new Random();

    public ListingActivity()
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public void Run()
    {
        StartMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);
        Console.WriteLine("You have 5 seconds to start thinking...");
        Pause(5);

        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("Item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
            elapsed++;
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndMessage();
    }
}
