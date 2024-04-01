public interface IActorRepo : IRepository<Actor>
{
    // specific methods
    Actor GetActorWithAwards();
}