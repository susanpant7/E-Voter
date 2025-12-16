using System.ComponentModel.DataAnnotations;

namespace E_Voter.Domain.Entities;

public class Province
{
    [Key]
    public int ProvinceId { get; set; }

    [Required]
    public string ProvinceName { get; set; }

    public string ProvinceCode { get; set; }

    // Navigation
    public ICollection<District> Districts { get; set; } = new List<District>();
}