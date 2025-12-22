namespace E_Voter.Application.ElectionParties;

public class ElectionPartySummary
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? LeaderName { get; set; }
    public int? LogoFileId { get; set; }
}
