internal class Lesson4
{
    private static void Lesson_4()
    {
        try
        {
            DateTime.Parse("asdf");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Something went wrong during parsing: {ex}");
        }
        finally
        {
            Console.WriteLine("Finally being entered");
        }

        // specific exceptions
        // try
        // {

        // }
        // catch (Exception as ex) when (ex.Message.Contains("specific condition"))
        // {
        //     // handle exception
        // }
    }
}