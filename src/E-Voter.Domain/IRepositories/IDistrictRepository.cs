using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IDistrictRepository
{
    Task<List<District>> GetDistrictsByProvinceIdAsync(int provinceId);
    Task<District?> GetByIdAsync(int id);
    Task<bool> HasDistrictsAsync(int provinceId);
    Task AddAsync(District district);
    Task UpdateAsync(District district);
    Task DeleteAsync(District district);
    Task<bool> ExistsByNameOrCodeAsync(string name, string? code, int? excludeId = null);
}