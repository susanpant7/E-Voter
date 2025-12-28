using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class VotingPlaceRepository(ApplicationDbContext context) : IVotingPlaceRepository
{
    public async Task<List<VotingPlace>> GetVotingPlacesByWardIdAsync(int wardId)
    {
        return await context.VotingPlaces
            .Where(v => v.WardId == wardId)
            .OrderBy(v => v.VotingPlaceName)
            .ToListAsync();
    }

    public async Task<VotingPlace?> GetByIdAsync(int id)
    {
        return await context.VotingPlaces
            .FirstOrDefaultAsync(vp => vp.VotingPlaceId == id);
    }

    public async Task AddAsync(VotingPlace votingPlace)
    {
        context.VotingPlaces.Add(votingPlace);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(VotingPlace votingPlace)
    {
        context.VotingPlaces.Update(votingPlace);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(VotingPlace votingPlace)
    {
        context.VotingPlaces.Remove(votingPlace);
        await context.SaveChangesAsync();
    }
    
    public async Task<bool> HasVotingPlacesAsync(int wardId)
    {
        return await context.VotingPlaces
            .AnyAsync(vp => vp.WardId == wardId);
    }
    
    public async Task<bool> ExistsByAddressAsync(string address, int? excludeId = null)
    {
        return await context.VotingPlaces
            .AnyAsync(v => (!excludeId.HasValue || v.VotingPlaceId != excludeId.Value)
                           && v.VotingPlaceAddress == address);
    }
}