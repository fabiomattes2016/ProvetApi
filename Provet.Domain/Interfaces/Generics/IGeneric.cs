namespace Provet.Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T entity);
        Task Delete(T entity);
        Task<List<T>> GetAll();
        Task<T> GetEntityById(int id);
        Task Update(T entity);
    }
}
