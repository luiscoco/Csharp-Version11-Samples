using System;

public class Person
{
    public required string Name { get; init; }
    public int Age { get; init; }
}

class Program
{
    static void Main()
    {
        var p = new Person { Name = "Ana", Age = 20 };
        Console.WriteLine($"{p.Name} ({p.Age})");
    }
}
