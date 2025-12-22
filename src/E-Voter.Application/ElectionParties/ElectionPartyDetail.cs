using E_Voter.Domain.Enums;

namespace E_Voter.Application.ElectionParties;

public class ElectionPartyDetail
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Abbreviation { get; set; } = null!;
    public string? Description { get; set; }

    public string? LeaderName { get; set; }
    public string? FounderName { get; set; }

    public DateTime FoundedOn { get; set; }
    public DateTime? RegisteredOn { get; set; } = DateTime.UtcNow;

    public bool IsRecognizedNationally { get; set; }
    public PartyStatus Status { get; set; }

    public string? Ideology { get; set; }
    public string? PoliticalSpectrum { get; set; }

    public string? OfficialWebsite { get; set; }
    public string? ContactEmail { get; set; }
    public string? ContactPhone { get; set; }

    public string? HeadquartersAddress { get; set; }

    // Reference to logo file
    public int? LogoFileId { get; set; }
    public string? LogoFileName { get; set; }
}