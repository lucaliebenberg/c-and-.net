internal class Program_16

{
    // Disposable Interface
    public class MyResource : IDisposable
    {
        private bool _disposed = false; // To detect redundant calls
        private SqlConnection _connection;

        // Implement IDisposable
        public void Dispose()
        {
            bool disposed = false;
            Console.WriteLine(_connection);
            if (!disposed)
            {
                _connection.Dispose();

                // Free your own state (unmanaged objects).
                disposed = true;
            }
        }
    }
}

internal class SqlConnection
{
    internal void Dispose()
    {
        throw new NotImplementedException();
    }
}