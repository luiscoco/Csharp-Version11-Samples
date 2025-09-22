using System;
using System.Text;

class Program
{
    static void Main()
    {
        ReadOnlySpan<byte> data = "Hola \u263A"u8;
        Console.WriteLine(Encoding.UTF8.GetString(data));
    }
}
