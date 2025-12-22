using E_Voter.Application.ElectionParties;
using E_Voter.Application.Shared;
using E_Voter.Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.ElectionParties;

[AllowAnonymous]
[ApiController]
[Route("api/election-parties")]
public class ElectionPartyController(IElectionPartyService service) : ControllerBase
{
    // GET: api/election-parties
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var parties = await service.GetElectionPartiesAsync();
        return Ok(ApiResponse<List<ElectionPartySummary>>.SuccessResponse(parties));
    }

    /// <summary>
    /// Get election party details by Id
    /// GET: api/election-parties/id
    /// </summary>
    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result = await service.GetByIdAsync(id);
        if (result == null)
            return NotFound(ApiResponse<ElectionPartyDetail>.ErrorResponse("Election party not found."));

        return Ok(ApiResponse<ElectionPartyDetail>.SuccessResponse(result));
    }
    
    // POST: api/election-parties
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ElectionPartyDetail dto)
    {
        var id = await service.AddAsync(dto);
        return Ok(
            ApiResponse<int>
                .SuccessResponse(id, "Election party created successfully")
        );
    }

    // PUT: api/election-parties/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] ElectionPartyDetail dto)
    {
        await service.UpdateAsync(id, dto);
        return Ok(
            ApiResponse<bool>
                .SuccessResponse(true, "Election party updated successfully")
        );
    }
    
    // DELETE: api/election-parties/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await service.DeleteAsync(id);
            return Ok(ApiResponse<bool>.SuccessResponse(true, "Election party deleted successfully"));
        }
        catch (EntityNotFoundException ex)
        {
            return NotFound(ApiResponse<bool>.ErrorResponse(ex.Message));
        }
    }
}
