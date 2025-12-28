using E_Voter.Application.VotingPlaces;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.VotingPlaces;

// TODO: split into different controllers and services
[ApiController]
[Route("api/voting-places")]
public class VotingPlaceController(IVotingPlaceService service) : ControllerBase
{
    // Province
    [HttpGet("provinces")]
    public async Task<IActionResult> GetProvinces()
    {
        var response = await service.GetProvincesAsync();
        return Ok(response);
    }

    [HttpPost("provinces")]
    public async Task<IActionResult> AddProvince(ProvinceAddRequest request)
        => Ok(await service.AddProvinceAsync(request));

    [HttpPut("provinces")]
    public async Task<IActionResult> UpdateProvince(ProvinceUpdateRequest request)
        => Ok(await service.UpdateProvinceAsync(request));

    [HttpDelete("provinces/{id}")]
    public async Task<IActionResult> DeleteProvince(int id)
        => Ok(await service.DeleteProvinceAsync(id));

    // District
    [HttpGet("provinces/{provinceId}/districts")]
    public async Task<IActionResult> GetDistricts(int provinceId)
    {
        var response = await service.GetDistrictsByProvinceIdAsync(provinceId);
        return Ok(response);
    }

    [HttpPost("districts")]
    public async Task<IActionResult> AddDistrict(DistrictAddRequest request)
        => Ok(await service.AddDistrictAsync(request));

    [HttpPut("districts")]
    public async Task<IActionResult> UpdateDistrict(DistrictUpdateRequest request)
        => Ok(await service.UpdateDistrictAsync(request));

    [HttpDelete("districts/{id}")]
    public async Task<IActionResult> DeleteDistrict(int id)
        => Ok(await service.DeleteDistrictAsync(id));

    // Municipality
    [HttpGet("districts/{districtId}/municipalities")]
    public async Task<IActionResult> GetMunicipalities(int districtId)
    {
        var response = await service.GetMunicipalitiesByDistrictIdAsync(districtId);
        return Ok(response);
    }

    [HttpPost("municipalities")]
    public async Task<IActionResult> AddMunicipality(MunicipalityAddRequest request)
        => Ok(await service.AddMunicipalityAsync(request));

    [HttpPut("municipalities")]
    public async Task<IActionResult> UpdateMunicipality(MunicipalityUpdateRequest request)
        => Ok(await service.UpdateMunicipalityAsync(request));

    [HttpDelete("municipalities/{id}")]
    public async Task<IActionResult> DeleteMunicipality(int id)
        => Ok(await service.DeleteMunicipalityAsync(id));

    // Ward
    [HttpGet("municipalities/{municipalityId}/wards")]
    public async Task<IActionResult> GetWards(int municipalityId)
    {
        var response = await service.GetWardsByMunicipalityIdAsync(municipalityId);
        return Ok(response);
    }

    [HttpPost("wards")]
    public async Task<IActionResult> AddWard(WardAddRequest request)
        => Ok(await service.AddWardAsync(request));

    [HttpPut("wards")]
    public async Task<IActionResult> UpdateWard(WardUpdateRequest request)
        => Ok(await service.UpdateWardAsync(request));

    [HttpDelete("wards/{id}")]
    public async Task<IActionResult> DeleteWard(int id)
        => Ok(await service.DeleteWardAsync(id));

    // VotingPlace
    [HttpGet("wards/{wardId}/voting-places")]
    public async Task<IActionResult> GetVotingPlaces(int wardId)
    {
        var response = await service.GetVotingPlacesByWardIdAsync(wardId);
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> AddVotingPlace(VotingPlaceAddRequest request)
        => Ok(await service.AddVotingPlaceAsync(request));

    [HttpPut]
    public async Task<IActionResult> UpdateVotingPlace(VotingPlaceUpdateRequest request)
        => Ok(await service.UpdateVotingPlaceAsync(request));

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteVotingPlace(int id)
        => Ok(await service.DeleteVotingPlaceAsync(id));
}