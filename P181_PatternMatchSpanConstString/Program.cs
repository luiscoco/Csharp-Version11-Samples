using System;

class Program
{
    static void Main()
    {
        ReadOnlySpan<char> span = "hello".AsSpan();
        if (span is "hello")
            Console.WriteLine("Matched constant string on Span<char>");
        else
            Console.WriteLine("No match");
    }
}
