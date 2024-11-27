public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        string reversed = new string(str.Reverse().ToArray());
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}

// Logging extension use-case
public enum LogLevel
{
    Information,
    Warning,
    Error
}

public interface ILogger
{
    void Log(LogLevel level, string message);
}

public static class LoggerExtensions
{
    public static void LogInformation(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Information, message);
    }

    public static void LogWarning(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Warning, message);
    }

    public static void LogError(this ILogger logger, string message)
    {
        logger.Log(LogLevel.Error, message);
    }
}