using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class MediaFile
{
    [Key]
    public int Id { get; set; }

    [Required]
    public byte[] Content { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string ContentType { get; set; } = null!;
    // image/png, image/jpeg, application/pdf, etc.

    [MaxLength(200)]
    public string? FileName { get; set; }

    public long Size { get; set; }

    public DateTime UploadedOn { get; set; } = DateTime.UtcNow;
}