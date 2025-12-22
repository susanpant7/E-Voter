using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IElectionPartyRepository
{
    Task<List<ElectionParty>> GetAllAsync();
    Task<ElectionParty?> GetByIdAsync(int id);
    Task<bool> ExistsByNameOrAbbreviationAsync(string name, string abbreviation, int? excludeId = null);
    Task AddAsync(ElectionParty party);
    Task UpdateAsync(ElectionParty party);
    Task DeleteAsync(ElectionParty entity);
}