using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IMunicipalityRepository
{
    Task<List<Municipality>> GetMunicipalitiesByDistrictIdAsync(int districtId);
    Task<Municipality?> GetByIdAsync(int id);
    Task<bool> HasMunicipalitiesAsync(int districtId);
    Task AddAsync(Municipality municipality);
    Task UpdateAsync(Municipality municipality);
    Task DeleteAsync(Municipality municipality);
    Task<bool> ExistsByNameOrCodeAsync(int districtId, string name, string? code, int? excludeId = null);
}
