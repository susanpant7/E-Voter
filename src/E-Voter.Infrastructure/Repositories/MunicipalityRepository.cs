using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class MunicipalityRepository(ApplicationDbContext context) : IMunicipalityRepository
{
    public async Task<List<Municipality>> GetMunicipalitiesByDistrictIdAsync(int districtId)
    {
        return await context.Municipalities
            .Where(m => m.DistrictId == districtId)
            .OrderBy(m => m.MunicipalityName)
            .ToListAsync();
    }

    public async Task<Municipality?> GetByIdAsync(int id)
    {
        return await context.Municipalities
            .FirstOrDefaultAsync(m => m.MunicipalityId == id);
    }

    public async Task<bool> HasMunicipalitiesAsync(int districtId)
    {
        return await context.Municipalities
            .AnyAsync(m => m.DistrictId == districtId);
    }

    public async Task AddAsync(Municipality municipality)
    {
        context.Municipalities.Add(municipality);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Municipality municipality)
    {
        context.Municipalities.Update(municipality);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Municipality municipality)
    {
        context.Municipalities.Remove(municipality);
        await context.SaveChangesAsync();
    }
    
    public async Task<bool> ExistsByNameOrCodeAsync(int districtId, string name, string? code, int? excludeId = null)
    {
        return await context.Municipalities
            .AnyAsync(m => m.DistrictId == districtId
                           && (!excludeId.HasValue || m.MunicipalityId != excludeId.Value)
                           && (m.MunicipalityName == name || (code != null && m.MunicipalityCode == code)));
    }
}
