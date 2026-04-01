using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Speakers;
using YoungConService.Services.Events.Speaker;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/speakers")]
public class SpeakersController(ISpeakerService service) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<SpeakerDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<SpeakerDTO>> GetById(Guid id)
    {
        var speaker = await service.GetByIdAsync(id);
        return speaker == null ? NotFound() : Ok(speaker);
    }

    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<SpeakerDTO>> Create([FromBody] CreateSpeakerRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<SpeakerDTO>> Update(Guid id, [FromBody] UpdateSpeakerRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}

