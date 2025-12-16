using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class Ward
{
    [Key]
    public int WardId { get; set; }

    [Required]
    public string WardName { get; set; }
    [Required]
    public int WardNumber { get; set; }

    // FK to Municipality
    [Required]
    public int MunicipalityId { get; set; }
    public Municipality Municipality { get; set; }

    // Navigation
    public ICollection<VotingPlace> VotingPlaces { get; set; } = new List<VotingPlace>();
}