using System;

public struct Measurements
{
    public int A;
    public double B;
}

class Program
{
    static void Main()
    {
        var m = new Measurements();
        Console.WriteLine($"A={m.A}, B={m.B}");
    }
}
