// Repository design implementation

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}

public class Repository<T> : IRepository<T> where T : class
{
    private readonly List<T> _entities = new List<T>();

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public T GetById(int id)
    {
        // Simulate fetching entity by ID
        return _entities[id];
    }

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public void Update(T entity)
    {
        // Logic for updating entity
    }

    public void Delete(T entity)
    {
        _entities.Remove(entity);
    }
}

// var customerRepository = new Repository<Customer>();
// var productRepository = new Repository<Product>();

// customerRepository.Add(new Customer { Id = Guid.NewGuid(), Name = "John Doe" });
// productRepository.Add(new Product { Id = Guid.NewGuid(), Name = "Product A" });