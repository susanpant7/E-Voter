using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IVotingPlaceRepository
{
    Task<List<VotingPlace>> GetVotingPlacesByWardIdAsync(int wardId);
    Task<VotingPlace?> GetByIdAsync(int id);
    Task AddAsync(VotingPlace votingPlace);
    Task UpdateAsync(VotingPlace votingPlace);
    Task DeleteAsync(VotingPlace votingPlace);
    Task<bool> HasVotingPlacesAsync(int wardId);
    Task<bool> ExistsByAddressAsync(string address, int? excludeId = null);
}