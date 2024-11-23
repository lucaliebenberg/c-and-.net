
using System.Diagnostics.Contracts;

internal class Program_1
{
    private static void Main(string[] args)
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