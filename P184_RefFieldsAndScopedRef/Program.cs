using System;

ref struct RefBox
{
    public ref int RefValue;
    public RefBox(ref int r) { RefValue = ref r; }
}

class Program
{
    static int Sum(scoped ref int a, scoped ref int b) => a + b;

    static ref int Bigger(ref int a, ref int b)
    {
        return ref (a > b ? ref a : ref b);
    }

    static void Main()
    {
        int x = 10, y = 20;
        var box = new RefBox(ref x);
        var total = Sum(ref x, ref y);
        Console.WriteLine($"sum={total}");
        ref int r = ref Bigger(ref x, ref y);
        r = 99;
        Console.WriteLine($"{x},{y}");
        box.RefValue = 5;
        Console.WriteLine($"{x},{y}");
    }
}
