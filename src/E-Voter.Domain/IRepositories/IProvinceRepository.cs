using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IProvinceRepository
{
    Task<List<Province>> GetAllProvincesAsync();
    Task<Province?> GetByIdAsync(int id);
    Task AddAsync(Province province);
    Task UpdateAsync(Province province);
    Task DeleteAsync(Province province);
    Task<bool> ExistsByNameOrCodeAsync(string provinceName, string? provinceCode, int? excludeId = null);
}