using BossEstate.Models.Entities;

namespace BossEstate.Services;

internal class UserService : GenericService<UserEntity>
{
    public override Task SaveAsync(UserEntity entity)
    {
        return base.SaveAsync(entity);
    }
}
