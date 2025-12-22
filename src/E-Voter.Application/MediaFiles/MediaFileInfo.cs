namespace E_Voter.Application.MediaFiles;

public class MediaFileInfo
{
    public byte[] Content { get; set; } = null!;
    public string ContentType { get; set; } = null!;
    public string? FileName { get; set; }
    public long Size { get; set; }
}