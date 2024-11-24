internal class Lesson5
{
    private static void Lesson_5()
    {
        // pattern matching
        object value = "Hello, World!";
        if (value is string str)
        {
            Console.WriteLine($"The value is a string: {str}");
        }
        else
        {
            Console.WriteLine("The value is not a string.");
        }

        // converison
        int a = 5;
        double b = (double)a; // explicit conversion

        // string textBoxAge = "42";
        // bool tryParseResult = int.TryParseResult(text, out int age);

        // if (!tryParseResult)
        // {
        //     Console.WriteLine(age);
        // }

    }
}