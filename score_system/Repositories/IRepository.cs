using score_system.Helpers;

namespace score_system.Repositories
{
    public interface IRepository<T> where T : class, IId
    {
        Task<PaginationGeneric<T>> GetAll(string[] includes, string typeOrder, int page, int registerForpage);
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<int> Save();
        Task<T> Delete(int id);
    }
}
