using Infrastructure.Contexts;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class AddressManager(AppDbContext context)
{
    private readonly AppDbContext _context = context;

    public async Task<UserEntity> GetAddressEntity(string UserId)
    {
        var user = await _context.Users.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == UserId);
        return user!;
    }

    public async Task<bool> CreateAddressAsync(AddressEntity entity)
    {
        _context.Addresses.Add(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> UpdateAddressAsync(string UserId)
    {
        var existing = await _context.Users.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == UserId);
        if (existing != null)
        {
            _context.Entry(existing).CurrentValues.SetValues(UserId);
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }
}
