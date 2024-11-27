using System.Diagnostics.Contracts;

public interface IDatabase
{
    void Connect();
    void Disconnect();
    bool IsConnected { get; }
}

public class MicrosoftSqlDatabase : IDatabase
{
    public bool IsConnected { get; private set; }

    public void Connect()
    {
        // Implementation code
        IsConnected = true;
    }

    public void Disconnect()
    {
        // Implementation code
        IsConnected = false;
    }
}