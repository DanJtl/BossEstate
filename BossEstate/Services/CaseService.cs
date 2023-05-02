using BossEstate.Contexts;
using BossEstate.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BossEstate.Services;

internal class CaseService : GenericService<CaseEntity>
{
    private readonly DataContext _context = new();

    public override async Task<IEnumerable<CaseEntity>> GetAllAsync()
    {
        return await _context.Cases
            .Include(x => x.User)
            .Include(x => x.StatusType)
            .ToListAsync();
    }

    public override async Task<CaseEntity> GetAsync(Expression<Func<CaseEntity, bool>> predicate)
    {
        var item = await _context.Cases
            .Include(x => x.StatusType)
            .Include(x => x.Comments)
            .Include(x => x.User)
            .Include(x => x.User).ThenInclude(x => x.Address)
            .FirstOrDefaultAsync(predicate);
        
        if (item != null)
            return item!;

        return null!;

    }
}
