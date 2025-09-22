file class Helper { public static string Ping() => "file-local OK"; }

class Program
{
    static void Main()
    {
        System.Console.WriteLine(Helper.Ping());
    }
}
