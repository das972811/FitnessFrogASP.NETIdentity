namespace FitnessFrogDb.Data;

public interface IEntityService<TEntity> where TEntity : class
{
    TEntity? Get(int id, bool includeRelatedEntities = true);

    IList<TEntity> GetList();

    void Add(TEntity entity);

    void Update(TEntity entity);

    void Delete(int id);
}