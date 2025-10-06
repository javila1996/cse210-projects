using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity ra = new ReflectionActivity();
                ra.Run();
            }
            else if (choice == "3")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
