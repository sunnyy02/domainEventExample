public class UnitOfWork : IUnitOfWork
{
    private readonly MovieDbContext _context;
    public UnitOfWork(MoveidDBContext dbContext)
    {
        _context = dbContext;
        Actor = new ActorRepository(_context);
    }

    public IActorRepository Actor { get; private set; }

    public Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}