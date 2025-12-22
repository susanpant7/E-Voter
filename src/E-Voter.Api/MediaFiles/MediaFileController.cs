using E_Voter.Application.ElectionParties;
using E_Voter.Application.MediaFiles;
using E_Voter.Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace E_Voter.Api.MediaFiles;

[ApiController]
[Route("api/media-files")]
public class MediaFileController(IMediaFileService mediaFileService) : ControllerBase
{
    // 1️⃣ Upload logo
    [HttpPost("upload")]
    public async Task<IActionResult> Upload([FromForm] IFormFile file)
    {
        if (file is null || file?.Length == 0)
            return BadRequest(ApiResponse<int>.ErrorResponse("File is required"));

        using var ms = new MemoryStream();
        await file.CopyToAsync(ms);

        var dto = new MediaFileInfo()
        {
            Content = ms.ToArray(),
            ContentType = file.ContentType,
            FileName = file.FileName,
            Size = file.Length
        };

        var id = await mediaFileService.UploadAsync(dto);
        return Ok(ApiResponse<int>.SuccessResponse(id));
    }

    // 2️⃣ Update existing logo
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromForm] IFormFile file)
    {
        using var ms = new MemoryStream();
        await file.CopyToAsync(ms);

        var dto = new MediaFileInfo()
        {
            Content = ms.ToArray(),
            ContentType = file.ContentType,
            FileName = file.FileName,
            Size = file.Length
        };

        await mediaFileService.UpdateAsync(id, dto);
        return Ok(ApiResponse<int>.SuccessResponse(id));
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var file = await mediaFileService.GetFileAsync(id);
        if (file == null) return NotFound();

        return File(file.Value.Content, file.Value.ContentType, file.Value.FileName);
    }
}