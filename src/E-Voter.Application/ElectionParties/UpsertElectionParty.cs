using E_Voter.Domain.Enums;

namespace E_Voter.Application.ElectionParties;

public class UpsertElectionParty
{
    public string Name { get; set; } = null!;
    public string Abbreviation { get; set; } = null!;
    public string? LeaderName { get; set; }
    public DateTime FoundedOn { get; set; }
    public PartyStatus Status { get; set; }

    public byte[]? Logo { get; set; }
    public string? LogoContentType { get; set; }
}
