using E_Voter.Application.Shared;
using E_Voter.Domain.Entities;
using E_Voter.Domain.IRepositories;

namespace E_Voter.Application.VotingPlaces;

public class VotingPlaceService(IProvinceRepository provinceRepository,
    IDistrictRepository districtRepository, IMunicipalityRepository municipalityRepository,
    IWardRepository wardRepository, IVotingPlaceRepository votingPlaceRepo) : IVotingPlaceService
{
    //Province
    public async Task<ApiResponse<int>> AddProvinceAsync(ProvinceAddRequest request)
    {
        if (await provinceRepository.ExistsByNameOrCodeAsync(request.ProvinceName, request.ProvinceCode))
            return ApiResponse<int>.ErrorResponse($"Province with the same name or code already exists.");

        var province = new Province
        {
            ProvinceName = request.ProvinceName,
            ProvinceCode = request.ProvinceCode
        };

        await provinceRepository.AddAsync(province);
        return ApiResponse<int>.SuccessResponse(province.ProvinceId);
    }

    public async Task<ApiResponse<bool>> UpdateProvinceAsync(ProvinceUpdateRequest request)
    {
        var province = await provinceRepository.GetByIdAsync(request.ProvinceId);
        if (province is null)
            return ApiResponse<bool>.ErrorResponse("Province not found", 404);

        if (await provinceRepository.ExistsByNameOrCodeAsync(request.ProvinceName, request.ProvinceCode, request.ProvinceId))
            return ApiResponse<bool>.ErrorResponse($"Province with the same name or code already exists.");

        province.ProvinceName = request.ProvinceName;
        province.ProvinceCode = request.ProvinceCode;

        await provinceRepository.UpdateAsync(province);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<bool>> DeleteProvinceAsync(int provinceId)
    {
        var province = await provinceRepository.GetByIdAsync(provinceId);
        if (province is null)
            return ApiResponse<bool>.ErrorResponse("Province not found", 404);

        if (await districtRepository.HasDistrictsAsync(provinceId))
            return ApiResponse<bool>.ErrorResponse(
                "Cannot delete province with existing districts", 409);

        await provinceRepository.DeleteAsync(province);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<List<ProvinceInfo>>> GetProvincesAsync()
    {
        var provinces = await provinceRepository.GetAllProvincesAsync();
        var dto = provinces.Select(p => new ProvinceInfo
        {
            ProvinceId = p.ProvinceId,
            ProvinceName = p.ProvinceName,
            ProvinceCode = p.ProvinceCode
        }).ToList();

        return ApiResponse<List<ProvinceInfo>>.SuccessResponse(dto);
    }

    //District
    public async Task<ApiResponse<int>> AddDistrictAsync(DistrictAddRequest request)
    {
        if (await districtRepository.ExistsByNameOrCodeAsync(request.DistrictName, request.DistrictCode))
            return ApiResponse<int>.ErrorResponse($"District with the same name or code already exists.");

        var district = new District
        {
            DistrictName = request.DistrictName,
            DistrictCode = request.DistrictCode,
            ProvinceId = request.ProvinceId
        };

        await districtRepository.AddAsync(district);
        return ApiResponse<int>.SuccessResponse(district.DistrictId);
    }

    public async Task<ApiResponse<bool>> UpdateDistrictAsync(DistrictUpdateRequest request)
    {
        var district = await districtRepository.GetByIdAsync(request.DistrictId);
        if (district is null)
            return ApiResponse<bool>.ErrorResponse("District not found", 404);
        if (await districtRepository.ExistsByNameOrCodeAsync(request.DistrictName, request.DistrictCode, request.DistrictId))
            return ApiResponse<bool>.ErrorResponse($"District with the same name or code already exists.");

        district.DistrictName = request.DistrictName;
        district.DistrictCode = request.DistrictCode;

        await districtRepository.UpdateAsync(district);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<bool>> DeleteDistrictAsync(int districtId)
    {
        var district = await districtRepository.GetByIdAsync(districtId);
        if (district is null)
            return ApiResponse<bool>.ErrorResponse("District not found", 404);

        if (await municipalityRepository.HasMunicipalitiesAsync(districtId))
            return ApiResponse<bool>.ErrorResponse(
                "Cannot delete district with existing municipalities", 409);

        await districtRepository.DeleteAsync(district);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<List<DistrictInfo>>> GetDistrictsByProvinceIdAsync(int provinceId)
    {
        var districts = await districtRepository.GetDistrictsByProvinceIdAsync(provinceId);
        var dto = districts.Select(d => new DistrictInfo
        {
            DistrictId = d.DistrictId,
            DistrictName = d.DistrictName,
            DistrictCode = d.DistrictCode,
            ProvinceId = d.ProvinceId
        }).ToList();

        return ApiResponse<List<DistrictInfo>>.SuccessResponse(dto);
    }

    //Municipality
    public async Task<ApiResponse<int>> AddMunicipalityAsync(MunicipalityAddRequest request)
    {
        if (await municipalityRepository.ExistsByNameOrCodeAsync(request.DistrictId, request.MunicipalityName, request.MunicipalityCode))
            return ApiResponse<int>.ErrorResponse("Municipality name or code already exists in this district.");

        var municipality = new Municipality
        {
            DistrictId = request.DistrictId,
            MunicipalityName = request.MunicipalityName,
            MunicipalityCode = request.MunicipalityCode,
            MunicipalityType = request.MunicipalityType
        };

        await municipalityRepository.AddAsync(municipality);
        return ApiResponse<int>.SuccessResponse(municipality.MunicipalityId);
    }

    public async Task<ApiResponse<bool>> UpdateMunicipalityAsync(MunicipalityUpdateRequest request)
    {
        var municipality = await municipalityRepository.GetByIdAsync(request.MunicipalityId);
        if (municipality is null) return ApiResponse<bool>.ErrorResponse("Municipality not found", 404);

        if (await municipalityRepository.ExistsByNameOrCodeAsync(request.DistrictId, request.MunicipalityName, request.MunicipalityCode, request.MunicipalityId))
            return ApiResponse<bool>.ErrorResponse("Municipality name or code already exists in this district.");

        municipality.DistrictId = request.DistrictId;
        municipality.MunicipalityName = request.MunicipalityName;
        municipality.MunicipalityCode = request.MunicipalityCode;
        municipality.MunicipalityType = request.MunicipalityType;

        await municipalityRepository.UpdateAsync(municipality);
        return ApiResponse<bool>.SuccessResponse(true);
    }


    public async Task<ApiResponse<bool>> DeleteMunicipalityAsync(int municipalityId)
    {
        var municipality = await municipalityRepository.GetByIdAsync(municipalityId);
        if (municipality is null)
            return ApiResponse<bool>.ErrorResponse("Municipality not found", 404);

        if (await wardRepository.HasWardsAsync(municipalityId))
            return ApiResponse<bool>.ErrorResponse(
                "Cannot delete municipality with existing wards", 409);

        await municipalityRepository.DeleteAsync(municipality);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<List<MunicipalityInfo>>> GetMunicipalitiesByDistrictIdAsync(int districtId)
    {
        var municipalities = await municipalityRepository.GetMunicipalitiesByDistrictIdAsync(districtId);
        var dto = municipalities.Select(m => new MunicipalityInfo
        {
            MunicipalityId = m.MunicipalityId,
            MunicipalityName = m.MunicipalityName,
            MunicipalityCode = m.MunicipalityCode,
            MunicipalityType = m.MunicipalityType
        }).ToList();

        return ApiResponse<List<MunicipalityInfo>>.SuccessResponse(dto);
    }

    //Ward
    public async Task<ApiResponse<int>> AddWardAsync(WardAddRequest request)
    {
        if (await wardRepository.ExistsByNameOrNumberAsync(request.MunicipalityId, request.WardName, request.WardNumber))
            return ApiResponse<int>.ErrorResponse("Ward name or number already exists in this municipality.");

        var ward = new Ward
        {
            MunicipalityId = request.MunicipalityId,
            WardName = request.WardName,
            WardNumber = request.WardNumber
        };

        await wardRepository.AddAsync(ward);
        return ApiResponse<int>.SuccessResponse(ward.WardId);
    }

    public async Task<ApiResponse<bool>> UpdateWardAsync(WardUpdateRequest request)
    {
        var ward = await wardRepository.GetByIdAsync(request.WardId);
        if (ward is null) return ApiResponse<bool>.ErrorResponse("Ward not found", 404);

        if (await wardRepository.ExistsByNameOrNumberAsync(request.MunicipalityId, request.WardName, request.WardNumber, request.WardId))
            return ApiResponse<bool>.ErrorResponse("Ward name or number already exists in this municipality.");

        ward.WardName = request.WardName;
        ward.WardNumber = request.WardNumber;
        ward.MunicipalityId = request.MunicipalityId;

        await wardRepository.UpdateAsync(ward);
        return ApiResponse<bool>.SuccessResponse(true);
    }


    public async Task<ApiResponse<bool>> DeleteWardAsync(int wardId)
    {
        var ward = await wardRepository.GetByIdAsync(wardId);
        if (ward is null)
            return ApiResponse<bool>.ErrorResponse("Ward not found", 404);

        if (await votingPlaceRepo.HasVotingPlacesAsync(wardId))
            return ApiResponse<bool>.ErrorResponse(
                "Cannot delete ward with existing voting places", 409);

        await wardRepository.DeleteAsync(ward);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<List<WardInfo>>> GetWardsByMunicipalityIdAsync(int municipalityId)
    {
        var wards = await wardRepository.GetWardsByMunicipalityIdAsync(municipalityId);
        var dto = wards.Select(w => new WardInfo
        {
            WardId = w.WardId,
            WardName = w.WardName,
            WardNumber = w.WardNumber
        }).ToList();

        return ApiResponse<List<WardInfo>>.SuccessResponse(dto);
    }

    //Voting Place
    public async Task<ApiResponse<int>> AddVotingPlaceAsync(VotingPlaceAddRequest request)
    {
        if (await votingPlaceRepo.ExistsByAddressAsync(request.VotingPlaceAddress))
            return ApiResponse<int>.ErrorResponse($"Voting Place with the same address already exists.");

        var votingPlace = new VotingPlace
        {
            VotingPlaceName = request.VotingPlaceName,
            VotingPlaceAddress = request.VotingPlaceAddress,
            WardId = request.WardId
        };

        await votingPlaceRepo.AddAsync(votingPlace);
        return ApiResponse<int>.SuccessResponse(votingPlace.VotingPlaceId);
    }

    public async Task<ApiResponse<bool>> UpdateVotingPlaceAsync(VotingPlaceUpdateRequest request)
    {
        var vp = await votingPlaceRepo.GetByIdAsync(request.VotingPlaceId);
        if (vp is null)
            return ApiResponse<bool>.ErrorResponse("Voting place not found", 404);
        if (await votingPlaceRepo.ExistsByAddressAsync(request.VotingPlaceAddress, request.VotingPlaceId))
            return ApiResponse<bool>.ErrorResponse($"Voting Place with the same address already exists.");

        vp.VotingPlaceName = request.VotingPlaceName;
        vp.VotingPlaceAddress = request.VotingPlaceAddress;

        await votingPlaceRepo.UpdateAsync(vp);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<bool>> DeleteVotingPlaceAsync(int votingPlaceId)
    {
        var vp = await votingPlaceRepo.GetByIdAsync(votingPlaceId);
        if (vp is null)
            return ApiResponse<bool>.ErrorResponse("Voting place not found", 404);

        await votingPlaceRepo.DeleteAsync(vp);
        return ApiResponse<bool>.SuccessResponse(true);
    }

    public async Task<ApiResponse<List<VotingPlaceInfo>>> GetVotingPlacesByWardIdAsync(int wardId)
    {
        var votingPlaces = await votingPlaceRepo.GetVotingPlacesByWardIdAsync(wardId);
        var dto = votingPlaces.Select(v => new VotingPlaceInfo
        {
            VotingPlaceId = v.VotingPlaceId,
            VotingPlaceName = v.VotingPlaceName,
            VotingPlaceAddress = v.VotingPlaceAddress
        }).ToList();

        return ApiResponse<List<VotingPlaceInfo>>.SuccessResponse(dto);
    }
}