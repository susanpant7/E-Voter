using E_Voter.Domain.Common;
using E_Voter.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class ElectionParty : BaseSoftDeletableEntity
{
    [Key]
    public int Id { get; set; }

    // Basic Info
    [Required]
    [MaxLength(200)]
    //unique 
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    //unique
    public string Abbreviation { get; set; } = null!;

    [MaxLength(500)]
    public string? Description { get; set; }

    // Leadership
    [MaxLength(150)]
    public string? LeaderName { get; set; }

    [MaxLength(150)]
    public string? FounderName { get; set; }

    // Registration & Status
    [Required]
    public DateTime FoundedOn { get; set; }

    public DateTime? RegisteredOn { get; set; }

    public bool IsRecognizedNationally { get; set; }

    public PartyStatus Status { get; set; }

    // Ideology & Orientation
    [MaxLength(200)]
    public string? Ideology { get; set; }

    [MaxLength(100)]
    public string? PoliticalSpectrum { get; set; }

    // Contact & Online Presence
    [MaxLength(200)]
    public string? OfficialWebsite { get; set; }

    [MaxLength(150)]
    public string? ContactEmail { get; set; }

    [MaxLength(30)]
    public string? ContactPhone { get; set; }

    // Headquarters
    [MaxLength(250)]
    public string? HeadquartersAddress { get; set; }

    // 🔗 Logo Reference
    public int? LogoFileId { get; set; }
    public MediaFile? LogoFile { get; set; }
    
    // Navigation Properties
    //public ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
    //public ICollection<ElectionResult> ElectionResults { get; set; } = new List<ElectionResult>();
}
