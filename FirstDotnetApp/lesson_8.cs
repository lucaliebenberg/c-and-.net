using System.Diagnostics.Contracts;

internal class Program
{
    // interfaces
    public interface IDatabase
    {
        void Connect();
        void Disconnect();
    }
}