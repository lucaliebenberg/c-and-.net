using System.Collections.Immutable;

internal class Program_12
{
    private static void Main()
    {
        var bus = new HashSet<string>();

        bus.Add("one");
        bus.Add("two");
        Console.WriteLine(bus);

        var dict = new Dictionary<int, string>();

        dict[1] = "Tom";
        dict[2] = "Ella";

        var things = new ImmutableArray<string>();

        things.Add("1");
        Console.WriteLine(things);
    }
}