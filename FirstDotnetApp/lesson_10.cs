// Generics

public class Box<T>
{
    private T _item;

    public void SetItem(T item)
    {
        _item = item;
    }

    public T GetItem()
    {
        return _item;
    }
}

internal class Program_10
{
    private static void Main()
    {
        var boxOfAString = new Box<string>();

        Box<int> intBox = new Box<int>();
        intBox.SetItem(10);
        Console.WriteLine(intBox.GetItem()); // 10

        Box<string> stringBox = new Box<string>();
        stringBox.SetItem("Hello");
        Console.WriteLine(stringBox.GetItem()); // Hello

        // stringBox.SetItem(123); // Compile-time error
    }
}

public interface ITrackedEntity
{
    Guid Id { get; set; }
}

public class DataManager<T> where T : class, ITrackedEntity
{
    public void Manage(T item)
    {
        Console.WriteLine($"Managing entity with ID: {item.Id}");
    }
}

public class KeyValuePairs
{
    public Dictionary<int, string> CreateDictionary()
    {
        return new Dictionary<int, string>
        {
            { 1, "One" },
            { 2, "Two" }
        };
    }
}