internal class Program_3 
{
    private static void Main()
    // few string methods
    {
        string name = "Luca";

        string greeting = $"Hello, {name}!";

        string emptyString = string.Empty; // ""

        var isNullOrEmpty = string.IsNullOrWhiteSpace(emptyString); // true
    }
}