using E_Voter.Domain.Enums;

namespace E_Voter.Application.VotingPlaces;

public record ProvinceAddRequest(string ProvinceName, string ProvinceCode);
public record ProvinceUpdateRequest(int ProvinceId, string ProvinceName, string ProvinceCode);

public record DistrictAddRequest(string DistrictName, string DistrictCode, int ProvinceId);
public record DistrictUpdateRequest(int DistrictId, string DistrictName, string DistrictCode);

public record MunicipalityAddRequest(
    string MunicipalityName,
    MunicipalityType MunicipalityType,
    string MunicipalityCode,
    int DistrictId);

public record MunicipalityUpdateRequest(
    int MunicipalityId,
    string MunicipalityName,
    MunicipalityType MunicipalityType,
    string MunicipalityCode,
    int DistrictId);

public record WardAddRequest(string WardName, int WardNumber, int MunicipalityId);
public record WardUpdateRequest(int WardId, string WardName, int WardNumber, int MunicipalityId);

public record VotingPlaceAddRequest(string VotingPlaceName, string VotingPlaceAddress, int WardId);
public record VotingPlaceUpdateRequest(int VotingPlaceId, string VotingPlaceName, string VotingPlaceAddress);
