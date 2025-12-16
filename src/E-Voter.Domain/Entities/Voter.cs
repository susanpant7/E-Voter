using E_Voter.Domain.Enums;

namespace E_Voter.Domain.Entities;

public class Voter
{
    public Guid VoterId { get; set; }

    // Identity
    public string VoterCardNumber { get; set; } = null!;
    public string MobileNumber { get; set; } = null!;

    // Personal Info
    public string FirstName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = null!;
    public Gender Gender { get; set; }

    // Status
    public bool IsVerified { get; set; }
    public bool IsActive { get; set; }
    public DateTime RegisteredAt { get; set; }

    // Voting Place
    public int VotingPlaceId { get; set; }
    public VotingPlace VotingPlace { get; set; } = null!;
}
