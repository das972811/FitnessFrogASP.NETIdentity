using Microsoft.EntityFrameworkCore;

namespace FitnessFrogDb.Data;

public abstract class BaseRepository<TEntity> : IEntityService<TEntity> where TEntity : class
{
    protected FitnessFrogContext Context { get; private set; }

    public BaseRepository(FitnessFrogContext context)
    {
        Context = context;
    }

    public abstract TEntity? Get(int id, bool includeRelatedEntities = true);

    public abstract IList<TEntity> GetList();

    public void Add(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
        Context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        Context.Entry(entity).State = EntityState.Modified;
        Context.SaveChanges();
    }

    public void Delete(int id)
    {
        var set = Context.Set<TEntity>();
        var entity = set.Find(id);
        set.Remove(entity!);
        Context.SaveChanges();
    }
}