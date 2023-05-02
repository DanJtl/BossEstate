using BossEstate.Contexts;
using BossEstate.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BossEstate.Services;

internal class UserService : GenericService<UserEntity>
{
    private readonly DataContext _context = new DataContext();

    public override async Task<IEnumerable<UserEntity>> GetAllAsync()
    {
        return await _context.Users.Include(x => x.Address).ToListAsync();
    }

    public override async Task<UserEntity> GetAsync(Expression<Func<UserEntity, bool>> predicate)
    {
        var item = await _context.Users.Include(x => x.Address).FirstOrDefaultAsync(predicate, CancellationToken.None);
        if (item != null)
            return item;

        return null!;
    }

}
