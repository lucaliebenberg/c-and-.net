public class Person(string name, int age = 37)
{

    // primary constructor
    public string Name { get; } = name;
    public int Age { get; } = age;
}

internal class Lesson_6
{
    private static void Main(string[] args)
    {
        var luca = new Person("Luca", 23);
        Console.WriteLine(luca);
    }
}