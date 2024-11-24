
using System.Diagnostics.Contracts;

internal class Lesson1
{
    private static void Lesson_1(string[] args)
    {
        var even = IsEven(4);
        var odd = IsEven(5);
        Console.WriteLine(even);
        Console.WriteLine(odd);
    }

    public static void PrintMessage()
    {
        Console.WriteLine();
    }
    
    public static bool IsEven(int number)
    {
        if (number % 2 == 0) {
            return true;
        }

        return false;
    }
}