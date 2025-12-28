using E_Voter.Application.Shared;

namespace E_Voter.Application.VotingPlaces;

public interface IVotingPlaceService
{
    // Province
    Task<ApiResponse<List<ProvinceInfo>>> GetProvincesAsync();
    Task<ApiResponse<int>> AddProvinceAsync(ProvinceAddRequest request);
    Task<ApiResponse<bool>> UpdateProvinceAsync(ProvinceUpdateRequest request);
    Task<ApiResponse<bool>> DeleteProvinceAsync(int provinceId);

    // District
    Task<ApiResponse<List<DistrictInfo>>> GetDistrictsByProvinceIdAsync(int provinceId);
    Task<ApiResponse<int>> AddDistrictAsync(DistrictAddRequest request);
    Task<ApiResponse<bool>> UpdateDistrictAsync(DistrictUpdateRequest request);
    Task<ApiResponse<bool>> DeleteDistrictAsync(int districtId);

    // Municipality
    Task<ApiResponse<List<MunicipalityInfo>>> GetMunicipalitiesByDistrictIdAsync(int districtId);
    Task<ApiResponse<int>> AddMunicipalityAsync(MunicipalityAddRequest request);
    Task<ApiResponse<bool>> UpdateMunicipalityAsync(MunicipalityUpdateRequest request);
    Task<ApiResponse<bool>> DeleteMunicipalityAsync(int municipalityId);

    // Ward
    Task<ApiResponse<List<WardInfo>>> GetWardsByMunicipalityIdAsync(int municipalityId);
    Task<ApiResponse<int>> AddWardAsync(WardAddRequest request);
    Task<ApiResponse<bool>> UpdateWardAsync(WardUpdateRequest request);
    Task<ApiResponse<bool>> DeleteWardAsync(int wardId);

    // VotingPlace
    Task<ApiResponse<List<VotingPlaceInfo>>> GetVotingPlacesByWardIdAsync(int wardId);
    Task<ApiResponse<int>> AddVotingPlaceAsync(VotingPlaceAddRequest request);
    Task<ApiResponse<bool>> UpdateVotingPlaceAsync(VotingPlaceUpdateRequest request);
    Task<ApiResponse<bool>> DeleteVotingPlaceAsync(int votingPlaceId);
}