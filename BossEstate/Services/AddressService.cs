using BossEstate.Contexts;
using BossEstate.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace BossEstate.Services;

internal class AddressService
{
    private readonly DataContext _context = new DataContext();

    public async Task<IEnumerable<AddressEntity>> GetAllAsync()
    {
        return await _context.Addresses.ToListAsync();
    }

    public async Task<AddressEntity> GetAsync(Expression<Func<AddressEntity, bool>> predicate)
    {
        var item = await _context.Addresses.FirstOrDefaultAsync(predicate, CancellationToken.None);
        if (item != null)
            return item;

        return null!;
    }

    public async Task<AddressEntity> SaveAsync(AddressEntity entity)
    {
        var addressEntity = await GetAsync(x => x.StreetName ==  entity.StreetName && x.PostalCode == entity.PostalCode && x.City == entity.City);
        if (addressEntity == null) 
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        return addressEntity;
    }
}
