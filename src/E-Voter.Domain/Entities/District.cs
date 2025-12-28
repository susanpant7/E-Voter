using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class District
{
    [Key]
    public int DistrictId { get; set; }

    [Required]
    [MaxLength(100)]
    public string DistrictName { get; set; }
    [MaxLength(50)]
    public string DistrictCode { get; set; }

    // FK to Province
    [Required]
    public int ProvinceId { get; set; }
    public Province Province { get; set; }

    // Navigation
    public ICollection<Municipality> Municipalities { get; set; } = new List<Municipality>();
}