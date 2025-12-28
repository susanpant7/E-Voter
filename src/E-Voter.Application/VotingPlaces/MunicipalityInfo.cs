using E_Voter.Domain.Enums;

namespace E_Voter.Application.VotingPlaces;

public class MunicipalityInfo
{
    public int MunicipalityId { get; set; }
    public string MunicipalityName { get; set; }
    public string MunicipalityCode { get; set; }
    public MunicipalityType MunicipalityType { get; set; }
}