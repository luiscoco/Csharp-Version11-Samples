using System;

class Program
{
    static void Main()
    {
        var raw = """
            Line 1
            "quotes" and \slashes\
            {braces} stay as-is
            """;

        Console.WriteLine(raw.Trim());
    }
}
