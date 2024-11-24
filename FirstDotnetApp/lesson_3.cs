internal class Lesson3
{
    private static void Lesson_3()
    // few string methods
    {
        string name = "Luca";

        string greeting = $"Hello, {name}!";

        string emptyString = string.Empty; // ""

        var isNullOrEmpty = string.IsNullOrWhiteSpace(emptyString); // true
    }
}