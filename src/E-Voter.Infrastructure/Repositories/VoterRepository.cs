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

        // Step 1: Normalize input
        string input = mobileNumber.Replace(" ", "");         // remove spaces
        string cleanMobile = input.StartsWith("+977")
            ? input.Substring(4)
            : input;

        // Step 2: Query database with simple conditions EF Core can translate
        return await context.Voters
            .Include(v => v.VotingPlace)
            .ThenInclude(vp => vp.Ward)
            .ThenInclude(w => w.Municipality)
            .ThenInclude(m => m.District)
            .ThenInclude(d => d.Province)
            .FirstOrDefaultAsync(v =>
                v.MobileNumber == input ||
                v.MobileNumber == $"+977{cleanMobile}" ||
                v.MobileNumber == cleanMobile);
    }

}