using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class WardRepository(ApplicationDbContext context) : IWardRepository
{
    public async Task<List<Ward>> GetWardsByMunicipalityIdAsync(int municipalityId)
    {
        return await context.Wards
            .Where(w => w.MunicipalityId == municipalityId)
            .OrderBy(w => w.WardNumber)
            .ToListAsync();
    }

    public async Task<Ward?> GetByIdAsync(int id)
    {
        return await context.Wards
            .FirstOrDefaultAsync(w => w.WardId == id);
    }
    
    public async Task<bool> HasWardsAsync(int municipalityId)
    {
        return await context.Wards
            .AnyAsync(w => w.MunicipalityId == municipalityId);
    }

    public async Task AddAsync(Ward ward)
    {
        context.Wards.Add(ward);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Ward ward)
    {
        context.Wards.Update(ward);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Ward ward)
    {
        context.Wards.Remove(ward);
        await context.SaveChangesAsync();
    }
    
    public async Task<bool> ExistsByNameOrNumberAsync(int municipalityId, string name, int number, int? excludeId = null)
    {
        return await context.Wards
            .AnyAsync(w => w.MunicipalityId == municipalityId
                           && (!excludeId.HasValue || w.WardId != excludeId.Value)
                           && (w.WardName == name || w.WardNumber == number));
    }

}
