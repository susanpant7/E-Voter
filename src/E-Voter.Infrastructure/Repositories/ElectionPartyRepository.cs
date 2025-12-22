using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class ElectionPartyRepository(ApplicationDbContext context) : IElectionPartyRepository
{
    // -------------------------
    // Queries
    // -------------------------

    public async Task<List<ElectionParty>> GetAllAsync()
    {
        return await context.ElectionParties
            .Where(p => p.DeletedBy == null)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<ElectionParty?> GetByIdAsync(int id)
    {
        return await context.ElectionParties
            .Include(p => p.LogoFile) // aggregate child
            .FirstOrDefaultAsync(p => p.Id == id && p.DeletedBy == null);
    }

    public async Task<bool> ExistsByNameOrAbbreviationAsync(
        string name,
        string abbreviation,
        int? excludeId = null)
    {
        return await context.ElectionParties
            .AnyAsync(p =>
                p.DeletedBy == null &&
                (p.Name == name || p.Abbreviation == abbreviation) &&
                (!excludeId.HasValue || p.Id != excludeId.Value));
    }

    // -------------------------
    // Commands
    // -------------------------

    public async Task AddAsync(ElectionParty party)
    {
        await context.ElectionParties.AddAsync(party);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ElectionParty party)
    {
        // Attach ensures EF tracks only changed fields
        context.ElectionParties.Attach(party);
        context.Entry(party).State = EntityState.Modified;

        await context.SaveChangesAsync();
    }
    
    public async Task DeleteAsync(ElectionParty entity)
    {
        context.ElectionParties.Remove(entity);
    }
}
