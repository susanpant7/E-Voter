using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;
using E_Voter.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace E_Voter.Infrastructure.Repositories;

public class MediaFileRepository(ApplicationDbContext context) : IMediaFileRepository
{
    public async Task<MediaFile> AddAsync(MediaFile file)
    {
        await context.MediaFiles.AddAsync(file);
        await context.SaveChangesAsync();
        return file;
    }

    public async Task<MediaFile?> GetByIdAsync(int id)
    {
        return await context.MediaFiles
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(MediaFile file)
    {
        context.MediaFiles.Attach(file);
        context.Entry(file).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }
    
    public async Task DeleteByIdAsync(int id)
    {
        var media = await context.MediaFiles.FindAsync(id);
        if (media != null)
            context.MediaFiles.Remove(media);
    }
}