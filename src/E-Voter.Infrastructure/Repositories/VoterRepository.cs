using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class VoterRepository(ApplicationDbContext context) : IVoterRepository
{
    public async Task<Voter?> GetByMobileNumberAsync(string mobileNumber)
    {
        if (string.IsNullOrWhiteSpace(mobileNumber))
            return null;

        // Normalize: remove +977 if present
        string cleanMobile = mobileNumber.StartsWith("+977") 
            ? mobileNumber.Substring(4) 
            : mobileNumber;

        return await context.Voters
            .Include(v => v.VotingPlace)
            .ThenInclude(vp => vp.Ward)
            .ThenInclude(w => w.Municipality)
            .ThenInclude(m => m.District)
            .ThenInclude(d => d.Province)
            .FirstOrDefaultAsync(v => 
                v.MobileNumber == mobileNumber || 
                v.MobileNumber == $"+977{cleanMobile}" ||
                v.MobileNumber == cleanMobile);
    }
}