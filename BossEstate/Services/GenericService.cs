using BossEstate.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BossEstate.Services;

internal abstract class GenericService<TEntity> where TEntity : class
{
    private readonly DataContext _context = new DataContext();

    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var item = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate, CancellationToken.None);
        if (item != null)
            return item;

        return null!;
    }

    public virtual async Task<TEntity> SaveAsync(TEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity> SaveAsync(TEntity entity, Expression<Func<TEntity, bool>> predicate)
    {
        var item = await GetAsync(predicate);
        if (item == null)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        return item;
    }
}
