namespace E_Voter.Application.Voter;

public class VoterProfile
{
    public Guid VoterId { get; set; }
    public string VoterCardNumber { get; set; } = null!;
    public string MobileNumber { get; set; } = null!;

    // Personal Info
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public string FullName =>
        string.IsNullOrWhiteSpace(MiddleName)
            ? $"{FirstName} {LastName}"
            : $"{FirstName} {MiddleName} {LastName}";

    public string Gender { get; set; } = null!;

    // Status
    public bool IsVerified { get; set; }
    public bool IsActive { get; set; }
    public DateTime RegisteredAt { get; set; }

    // Location
    public string VotingPlaceName { get; set; } = null!;
    public string VotingPlaceAddress { get; set; } = null!;

    public string WardName { get; set; } = null!;
    public int WardNumber { get; set; }

    public string MunicipalityName { get; set; } = null!;
    public string MunicipalityType { get; set; } = null!;

    public string DistrictName { get; set; } = null!;
    public string DistrictCode { get; set; } = null!;
    public string ProvinceName { get; set; } = null!;
}
