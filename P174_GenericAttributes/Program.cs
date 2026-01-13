using System;

public class ExampleAttribute<T> : Attribute {}

[Example<int>]
class Demo
{
    static void Main() => Console.WriteLine("Generic attribute applied.");
}
