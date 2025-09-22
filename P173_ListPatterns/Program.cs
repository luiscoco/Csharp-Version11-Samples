using System;

class Program
{
    static string Classify(int[] a) => a switch
    {
        [] => "empty",
        [1, 2, ..] => "starts with 1,2",
        [.., 9] => "ends with 9",
        [var first, .. var rest] when rest.Length > 0 => $"first={first}, rest length={rest.Length}",
        _ => "other"
    };

    static void Main()
    {
        Console.WriteLine(Classify(Array.Empty<int>()));
        Console.WriteLine(Classify(new[]{1,2,3}));
        Console.WriteLine(Classify(new[]{3,4,9}));
        Console.WriteLine(Classify(new[]{7,8}));
    }
}
