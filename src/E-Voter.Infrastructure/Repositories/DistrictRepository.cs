using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class DistrictRepository(ApplicationDbContext context) : IDistrictRepository
{
    public async Task<List<District>> GetDistrictsByProvinceIdAsync(int provinceId)
    {
        return await context.Districts
            .Where(d => d.ProvinceId == provinceId)
            .OrderBy(d => d.DistrictName)
            .ToListAsync();
    }

    public async Task<District?> GetByIdAsync(int id)
    {
        return await context.Districts
            .FirstOrDefaultAsync(d => d.DistrictId == id);
    }

    public async Task<bool> HasDistrictsAsync(int provinceId)
    {
        return await context.Districts
            .AnyAsync(d => d.ProvinceId == provinceId);
    }

    public async Task AddAsync(District district)
    {
        context.Districts.Add(district);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(District district)
    {
        context.Districts.Update(district);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(District district)
    {
        context.Districts.Remove(district);
        await context.SaveChangesAsync();
    }
    
    public async Task<bool> ExistsByNameOrCodeAsync(string provinceName, string? provinceCode, int? excludeId = null)
    {
        return await context.Districts.AnyAsync(p =>
            (!excludeId.HasValue || p.DistrictId != excludeId.Value) &&
            (p.DistrictName == provinceName || (provinceCode != null && p.DistrictCode == provinceCode))
        );
    }
}
