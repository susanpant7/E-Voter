using System.ComponentModel.DataAnnotations;
using E_Voter.Domain.Enums;

namespace E_Voter.Domain.Entities;

public class Municipality
{
    [Key]
    public int MunicipalityId { get; set; }

    [Required]
    [MaxLength(100)]
    public string MunicipalityName { get; set; }

    public MunicipalityType MunicipalityType { get; set; } // Metropolitan, Sub-Metro, Municipality, Rural

    [MaxLength(50)]
    public string MunicipalityCode { get; set; }

    // FK to District
    [Required]
    public int DistrictId { get; set; }
    public District District { get; set; }

    // Navigation
    public ICollection<Ward> Wards { get; set; } = new List<Ward>();
}