using System;

class Program
{
    static void Main()
    {
        IntPtr a = 3;
        a += 4;
        Console.WriteLine(a);
        Console.WriteLine(a > (IntPtr)2);
    }
}
