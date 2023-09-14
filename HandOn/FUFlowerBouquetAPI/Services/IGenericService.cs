
using DataAccessObject.Utils;

namespace ClubMemberShip.Service;

public interface IGenericService<TEntity> where TEntity : class
{
    public List<TEntity>? Get();
    public Pagination<TEntity> GetPagination(int pageIndex, int pageSize);
    public TEntity? GetById(object? id);
    public void Update(TEntity newEntity);
    public void Delete(object idToDelete);
    public void Add(TEntity newEntity);
}