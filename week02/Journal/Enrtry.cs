public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine();
    }

    // Returns a string suitable for saving to a file
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    // Creates an Entry from a string loaded from a file
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length != 3) return null;
        return new Entry(parts[1], parts[2], parts[0]);
    }
}
