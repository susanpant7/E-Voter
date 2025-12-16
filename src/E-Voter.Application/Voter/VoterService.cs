using E_Voter.Domain.IRepositories;

namespace E_Voter.Application.Voter;

public class VoterService(IVoterRepository voterRepository) : IVoterService
{
    public async Task<VoterProfile?> GetVoterProfileAsync(string mobileNumber)
    {
        var voter = await voterRepository.GetByMobileNumberAsync(mobileNumber);

        if (voter == null || voter.VotingPlace?.Ward?.Municipality?.District?.Province == null)
            return null;

        return new VoterProfile
        {
            VoterId = voter.VoterId,
            VoterCardNumber = voter.VoterCardNumber,
            MobileNumber = voter.MobileNumber,
            FirstName = voter.FirstName,
            LastName = voter.LastName,
            Gender = voter.Gender.ToString(),
            RegisteredAt = voter.RegisteredAt,
            IsVerified = voter.IsVerified,
            IsActive = voter.IsActive,

            VotingPlaceName = voter.VotingPlace.VotingPlaceName,
            VotingPlaceAddress = voter.VotingPlace.VotingPlaceAddress,

            WardName = voter.VotingPlace.Ward.WardName,
            WardNumber = voter.VotingPlace.Ward.WardNumber,

            MunicipalityName = voter.VotingPlace.Ward.Municipality.MunicipalityName,
            MunicipalityType = voter.VotingPlace.Ward.Municipality.MunicipalityType.ToString(),

            DistrictName = voter.VotingPlace.Ward.Municipality.District.DistrictName,
            DistrictCode = voter.VotingPlace.Ward.Municipality.District.DistrictCode,

            ProvinceName = voter.VotingPlace.Ward.Municipality.District.Province.ProvinceName
        };
    }
}