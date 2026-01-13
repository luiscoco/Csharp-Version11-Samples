using System;

class Program
{
    static string ToS(int x) => x.ToString();
    static void Main()
    {
        Func<int, string> f = ToS;
        Console.WriteLine(f(42));
    }
}
