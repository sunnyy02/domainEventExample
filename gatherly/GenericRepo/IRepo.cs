public interface IRepository<T> where T : class
{
    T GetById(int id);
    IEnumerable<T> GetAll();
    Enumerable<T> Find(Expression<Func<T, bool>> predicate);

    void Add(T entity);
    void Remove(T entity);


}