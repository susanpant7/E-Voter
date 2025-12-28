using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class ProvinceRepository(ApplicationDbContext context) : IProvinceRepository
{
    public async Task<List<Province>> GetAllProvincesAsync()
    {
        return await context.Provinces
            .OrderBy(p => p.ProvinceId)
            .ToListAsync();
    }
    
    public async Task<Province?> GetByIdAsync(int id)
    {
        return await context.Provinces
            .FirstOrDefaultAsync(p => p.ProvinceId == id);
    }

    public async Task AddAsync(Province province)
    {
        context.Provinces.Add(province);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Province province)
    {
        context.Provinces.Update(province);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Province province)
    {
        context.Provinces.Remove(province);
        await context.SaveChangesAsync();
    }
    
    public async Task<bool> ExistsByNameOrCodeAsync(string provinceName, string? provinceCode, int? excludeId = null)
    {
        return await context.Provinces.AnyAsync(p =>
            (!excludeId.HasValue || p.ProvinceId != excludeId.Value) &&
            (p.ProvinceName == provinceName || (provinceCode != null && p.ProvinceCode == provinceCode))
        );
    }
}
