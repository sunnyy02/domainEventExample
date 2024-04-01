public interface IUnitOfWork : IDisposable
{
    IActorRepository ActorRepository { get; }
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}