using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IWardRepository
{
    Task<List<Ward>> GetWardsByMunicipalityIdAsync(int municipalityId);
    Task<Ward?> GetByIdAsync(int id);
    Task<bool> HasWardsAsync(int municipalityId);
    Task AddAsync(Ward ward);
    Task UpdateAsync(Ward ward);
    Task DeleteAsync(Ward ward);
    Task<bool> ExistsByNameOrNumberAsync(int municipalityId, string name, int number, int? excludeId = null);
}