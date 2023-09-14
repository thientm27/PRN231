
using ClubMemberShip.Repo.UnitOfWork;
using DataAccessObject.Utils;

namespace ClubMemberShip.Service.Service;

public abstract class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
{
    protected readonly UnitOfWork UnitOfWork;

    protected GenericService(UnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }
    public abstract List<TEntity>? Get();
    public abstract Pagination<TEntity> GetPagination(int pageIndex, int pageSize);
    public abstract TEntity? GetById(object? id);
    public abstract void Update(TEntity newEntity);
    public abstract void Delete(object idToDelete);
    public abstract void Add(TEntity newEntity);

 
}
