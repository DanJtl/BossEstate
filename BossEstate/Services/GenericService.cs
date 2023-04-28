using BossEstate.Contexts;
using BossEstate.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BossEstate.Services;

internal abstract class GenericService<TEntity> where TEntity : class
{
    private readonly DataContext _context = new DataContext();

    public async Task SaveAsync(TEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
    }
}
