using E_Voter.Domain.Entities;

namespace E_Voter.Domain.IRepositories;

public interface IMediaFileRepository
{
    Task<MediaFile> AddAsync(MediaFile file);
    Task<MediaFile?> GetByIdAsync(int id);
    Task UpdateAsync(MediaFile file);
    Task DeleteByIdAsync(int id);
}