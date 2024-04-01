public class RepoImplementation : IRepository<T> where T : class
{
    private readonly ActorDbContext _context;
    public RepoImplementation(ActorDbContext dbContext)
    {
        _context = dbContext;
    }

    void Add(T entity)
    {
        _context.Set<T>.Add(entity);
    }

    IEnmuerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>.Where(predicate);
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
}