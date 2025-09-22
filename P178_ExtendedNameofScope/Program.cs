using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Parameter)]
public sealed class NameAttribute : Attribute
{
    public string Name { get; }
    public NameAttribute(string name) => Name = name;
}

class Program
{
    static void Method([Name(nameof(x))] int x)
    {
    }

    static void Main()
    {
        var p = typeof(Program).GetMethod("Method", BindingFlags.NonPublic | BindingFlags.Static)!
                .GetParameters()[0];
        var attr = (NameAttribute)Attribute.GetCustomAttribute(p, typeof(NameAttribute))!;
        Console.WriteLine(attr.Name);
    }
}
