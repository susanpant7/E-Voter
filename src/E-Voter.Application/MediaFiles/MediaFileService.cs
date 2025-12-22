using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;

namespace E_Voter.Application.MediaFiles;

public class MediaFileService(IMediaFileRepository mediaFileRepository) : IMediaFileService
{
    public async Task<int> UploadAsync(MediaFileInfo dto)
    {
        var mediaFile = new MediaFile
        {
            Content = dto.Content,
            ContentType = dto.ContentType,
            FileName = dto.FileName,
            Size = dto.Size
        };

        var saved = await mediaFileRepository.AddAsync(mediaFile);
        return saved.Id;
    }

    public async Task UpdateAsync(int mediaFileId, MediaFileInfo dto)
    {
        var mediaFile = await mediaFileRepository.GetByIdAsync(mediaFileId)
                        ?? throw new InvalidOperationException("Media file not found");

        mediaFile.Content = dto.Content;
        mediaFile.ContentType = dto.ContentType;
        mediaFile.FileName = dto.FileName;
        mediaFile.Size = dto.Size;
        mediaFile.UploadedOn = DateTime.UtcNow;

        await mediaFileRepository.UpdateAsync(mediaFile);
    }
    
    public async Task<(byte[] Content, string ContentType, string? FileName)?> GetFileAsync(int id)
    {
        var file = await mediaFileRepository.GetByIdAsync(id);
        if (file == null) return null;
        return (file.Content, file.ContentType, file.FileName);
    }
}