using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IVoterRepository
{
    Task<Voter?> GetByMobileNumberAsync(string mobileNumber);
}