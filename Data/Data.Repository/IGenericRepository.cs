namespace Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T Get<TKey>(TKey id);
        System.Linq.IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
    }
}