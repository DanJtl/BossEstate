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

    public async Task<AddressEntity> GetAsync(int id)
    {
        var item = await _context.Addresses.FindAsync(id);
        if (item != null)
            return item;

        return null!;
    }

    public async Task<AddressEntity> SaveAsync(AddressEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}
