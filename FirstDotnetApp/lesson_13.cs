using System.Diagnostics.Metrics;

internal class Lesson_14
{
    private static void Main()
    {
        int counter = 0;

        Func<int, int> incrementCounter = num =>
        {
            counter = num + counter;
            return counter;
        };
        Console.WriteLine(incrementCounter(1));
        Console.WriteLine(incrementCounter(3));
        Console.WriteLine(incrementCounter(6));
    }
}