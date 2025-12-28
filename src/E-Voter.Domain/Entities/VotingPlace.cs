using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class VotingPlace
{
    [Key]
    public int VotingPlaceId { get; set; }

    [Required]
    public string VotingPlaceName { get; set; }
    [MaxLength(200)]
    public string VotingPlaceAddress { get; set; }

    // FK to Ward
    [Required]
    public int WardId { get; set; }
    public Ward Ward { get; set; }
}