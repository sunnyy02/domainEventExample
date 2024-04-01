public class ActorRepository : RepositoryImplementation<Actor>, IActorRepository
{
    public ActorRepository(MovieDbContext context) : base(context)
    {

    }
}