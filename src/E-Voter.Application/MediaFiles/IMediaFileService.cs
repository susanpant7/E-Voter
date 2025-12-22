namespace E_Voter.Application.MediaFiles;

public interface IMediaFileService
{
    Task<int> UploadAsync(MediaFileInfo dto);
    Task UpdateAsync(int mediaFileId, MediaFileInfo dto);
    Task<(byte[] Content, string ContentType, string? FileName)?> GetFileAsync(int id);
}