using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        var numbers = new List<int>();
        Console.WriteLine("Enter numbers one per line. Enter 0 to finish.");

        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int value))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (value == 0)
            {
                break;
            }

            numbers.Add(value);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered. Nothing to calculate.");
            return;
        }

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        double average = (double)sum / numbers.Count;

        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"\nSum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Maximum: {max}");
    }

}