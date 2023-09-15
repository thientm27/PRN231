using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;


namespace ClubMemberShip.Repo.Repository;

public class GenericRepo<TEntity> 
    where TEntity : class
{
    protected readonly MyDbContext Context = new();

    public GenericRepo(MyDbContext context)
    {
        this.Context = context;
    }

    public List<TEntity> Get(
             Expression<Func<TEntity, bool>>? filter = null,
             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
             string includeProperties = "")
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        if (filter != null)
        {
            query = query.Where(filter);
        }

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includeProperty in includeProperties.Split
                         (new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
        }

        if (orderBy != null)
        {
            return orderBy(query).ToList();
        }

        return query.ToList();
    }


    public TEntity Create(TEntity entity)
    {
        return Context.Set<TEntity>().Add(entity).Entity;
    }

    public void Update(TEntity entityToUpdate)
    {
        Context.Set<TEntity>().Attach(entityToUpdate);
        Context.Entry(entityToUpdate).State = EntityState.Modified;
    }
    public virtual TEntity GetByID(object id)
    {
        return Context.Set<TEntity>().Find(id);
    }
    public void DeleteById(object? id)
    {
        var entity = GetByID(id);
        if (entity != null)
        {
            Delete(entity);
        }

    }

    public virtual void Delete(TEntity entityToDelete)
    {
        if (Context.Entry(entityToDelete).State == EntityState.Detached)
        {
            Context.Set<TEntity>().Attach(entityToDelete);
        }
        Context.Set<TEntity>().Remove(entityToDelete);
    }


}