using System;
using System.Numerics;

class Program
{
    static T SumAll<T>(ReadOnlySpan<T> values) where T : INumber<T>
    {
        T sum = T.Zero;
        for (int i = 0; i < values.Length; i++)
            sum += values[i];
        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SumAll<int>(stackalloc[] { 1, 2, 3 }));
        Console.WriteLine(SumAll<double>(stackalloc[] { 1.5, 2.5 }));
    }
}
